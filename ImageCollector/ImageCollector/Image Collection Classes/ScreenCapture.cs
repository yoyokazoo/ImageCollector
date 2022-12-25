﻿using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.IO;

// taken from http://www.developerfusion.com/code/4630/capture-a-screen-shot/ with heavy modifications done
// TODO: How to share this between projects easily?  Project that builds a DLL and add that DLL as a reference?

namespace ImageCollector
{
    // TODO: Split the regions into different classes?
    // Top level functionality goes somewhere, helpers exist separately, etc.
    public static class ScreenCapture
    {
        #region Constants

        private const string DEFAULT_TEST_SCREENSHOT_FOLDER = "TestScreenshots";

        #endregion

        #region DLL Imports

        // Helper class containing Gdi32 API functions
        private class Gdi32
        {

            public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter
            [DllImport("gdi32.dll")]
            public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
                int nWidth, int nHeight, IntPtr hObjectSource,
                int nXSrc, int nYSrc, int dwRop);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
                int nHeight);
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteDC(IntPtr hDC);
            [DllImport("gdi32.dll")]
            public static extern bool DeleteObject(IntPtr hObject);
            [DllImport("gdi32.dll")]
            public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
        }

        // Helper class containing User32 API functions
        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }
            [DllImport("user32.dll")]
            public static extern IntPtr GetDesktopWindow();
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
            [DllImport("user32.dll")]
            public static extern int SetForegroundWindow(IntPtr hWnd);
        }

        #endregion

        #region Color Matching (deprecated?)

        private static Color findAverageColor(Point corner, int GEM_WIDTH, int GEM_HEIGHT, Bitmap bm)
        {
            int rSum = 0;
            int gSum = 0;
            int bSum = 0;
            int numColors = 36; // precalced for speed, needs to change if the bounds change

            int lowerBoundX = (GEM_WIDTH / 2) - 3;
            int upperBoundX = (GEM_WIDTH / 2) + 3;

            int lowerBoundY = (GEM_HEIGHT / 2) - 3;
            int upperBoundY = (GEM_HEIGHT / 2) + 3;

            for (int x = lowerBoundX; x < upperBoundX; x++)
            {
                for (int y = lowerBoundY; y < upperBoundY; y++)
                {
                    Color pixel = bm.GetPixel(corner.X + x, corner.Y + y);
                    rSum += pixel.R;
                    gSum += pixel.G;
                    bSum += pixel.B;
                }
            }
            return Color.FromArgb(rSum / numColors, gSum / numColors, bSum / numColors);
        }

        private static Color[] findKeyColorPoints(Point corner, int GEM_WIDTH, int GEM_HEIGHT, Bitmap bm)
        {
            Color[] colors = new Color[9];

            int[] xCoords = { (GEM_WIDTH / 2) - 3, (GEM_WIDTH / 2), (GEM_WIDTH / 2) + 3 };
            int[] yCoords = { (GEM_HEIGHT / 2) - 3, (GEM_HEIGHT / 2), (GEM_HEIGHT / 2) + 3 };

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Color pixel = bm.GetPixel(corner.X + xCoords[x], corner.Y + yCoords[y]);
                    colors[x * 3 + y] = pixel;
                }
            }
            return colors;
        }

        // defaults are set to king.com width and height
        private static Rectangle findTopCornerRectFromRoundedCorner(Bitmap pic, Color outerColor, Color cornerColor, int gameWidth = 775, int gameHeight = 600)
        {
            // we look 1 pixel behind, hence starting at 1
            for (int x = 1; x < pic.Width - 15; x++)
            {
                for (int y = 1; y < pic.Height - 15; y++)
                {
                    if (colorsAlmostMatch(pic.GetPixel(x - 1, y - 1), outerColor) &&
                        colorsAlmostMatch(pic.GetPixel(x - 1, y + 15), outerColor) &&
                        colorsAlmostMatch(pic.GetPixel(x + 15, y - 1), outerColor) &&
                        colorsAlmostMatch(pic.GetPixel(x, y + 15), cornerColor, 35) &&
                        colorsAlmostMatch(pic.GetPixel(x + 15, y), cornerColor, 35))
                    {
                        return new Rectangle(x, y, gameWidth, gameHeight);
                    }
                }
            }

            return new Rectangle(-1, -1, -1, -1);
        }

        private static bool colorsExactlyMatch(Color firstColor, Color secondColor)
        {
            if (firstColor.R == secondColor.R &&
                firstColor.G == secondColor.G &&
                firstColor.B == secondColor.B)
            {
                return true;
            }

            return false;
        }

        private static bool colorsAlmostMatch(Color firstColor, Color secondColor, int threshold = 20)
        {
            int r = Math.Abs(firstColor.R - secondColor.R);
            int g = Math.Abs(firstColor.G - secondColor.G);
            int b = Math.Abs(firstColor.B - secondColor.B);

            if (r > threshold || g > threshold || b > threshold)
            {
                return false;
            }

            return true;
        }

        #endregion

        #region Window Handles and Processes

        public static void ListAllRunningProcesses()
        {
            Process[] processes = Process.GetProcesses();
            List<string> processStrings = new List<string>();

            foreach (Process p in processes)
            {
                processStrings.Add($"Process: {p.ProcessName}\t{p.MainWindowTitle}\t{p.Id}");
            }

            processStrings.Sort();
            processStrings.ForEach(s => Console.WriteLine(s));
        }

        public static IntPtr GetWindowHandleByName(string processName)
        {
            Process p = Process.GetProcessesByName(processName).FirstOrDefault();
            return p?.MainWindowHandle ?? IntPtr.Zero;
        }

        public static void SaveTestScreenshotOfAllProcesses()
        {
            SaveTestScreenshotsOfAllProcessesWithName(null, checkValidity: true);
        }

        public static void SaveTestScreenshotsOfAllProcessesWithName(string processName, bool checkValidity = false)
        {
            // find window handles
            Process[] processes;
            string folderName = "AllProcesses";

            if (processName == null)
            {
                processes = Process.GetProcesses();
            }
            else
            {
                processes = Process.GetProcessesByName(processName);
                folderName = $"TestScreenshotsOf{processName}";
            }
                
            int processNum = 0;
            CreateEmptyFolder(folderName);

            foreach (Process p in processes)
            {
                Bitmap processScreenshot = CaptureBitmapFromWindowHandle(p.MainWindowHandle);
                if(checkValidity && !BitmapIsValid(processScreenshot))
                {
                    Console.WriteLine($"Bitmap invalid for process {p.ProcessName} ({processNum}), skipping save");
                    continue;
                }
                SaveBitmapToFile(processScreenshot, $"{folderName}{Path.DirectorySeparatorChar}Test_{p.ProcessName}_{processNum}.bmp");
                processNum++;
            }
        }

        #endregion

        #region File and Directory Management

        // Creates a folder if it doesn't exist, and blows away existing content if it does
        public static string CreateEmptyFolder(string folderName)
        {
            string newFolderPath = CreateFolder(folderName);
            BlowAwayFolderContents(newFolderPath);

            return newFolderPath;
        }

        // Creates a folder if it doesn't exist, returns path
        public static string CreateFolder(string folderName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string newDirectoryPath = Path.Combine(currentDirectory, folderName);

            Directory.CreateDirectory(newDirectoryPath);

            return newDirectoryPath;
        }

        private static void BlowAwayFolderContents(string folderPath)
        {
            var files = Directory.EnumerateFiles(folderPath);

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        public static void SaveBitmapToFile(Bitmap bmp, string fileName)
        {
            bmp.Save(fileName, ImageFormat.Bmp);
        }

        #endregion

        #region Screen Capturing

        // Always deal in Bitmaps, if possible, so we can check their pixel values.
        // Methods that save bitmaps should be prefixed with SaveTest, to indicate they shouldn't be used in live applications

        public static void SaveTestDesktopScreenshot(string fileName)
        {
            string folderPath = CreateFolder(DEFAULT_TEST_SCREENSHOT_FOLDER);
            string imagePath = Path.Combine(folderPath, fileName);

            Bitmap bmp = CaptureBitmapFromDesktop();
            bmp.Save(imagePath, ImageFormat.Bmp);
        }

        private static Bitmap CaptureBitmapFromDesktop()
        {
            IntPtr handle = User32.GetDesktopWindow();

            return CaptureBitmapFromWindowHandle(handle);
        }

        public static Bitmap CaptureBitmapFromDesktopAndRectangle(Rectangle rect)
        {
            IntPtr handle = User32.GetDesktopWindow();

            return CaptureBitmapFromWindowHandleAndRectangle(handle, rect);
        }

        private static Bitmap CaptureBitmapFromWindowHandle(IntPtr handle)
        {
            User32.Rect windowRect = new User32.Rect();
            User32.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;

            Rectangle rect = new Rectangle(0, 0, width, height);

            return CaptureBitmapFromWindowHandleAndRectangle(handle, rect);
        }

        private static Bitmap CaptureBitmapFromWindowHandleAndRectangle(IntPtr handle, Rectangle rect)
        {
            IntPtr hdcSrc = User32.GetWindowDC(handle);
            IntPtr hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);

            IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, rect.Width, rect.Height);
            IntPtr hOld = Gdi32.SelectObject(hdcDest, hBitmap);
            Gdi32.BitBlt(hdcDest, 0, 0, rect.Width, rect.Height, hdcSrc, rect.Left, rect.Top, Gdi32.SRCCOPY);

            Gdi32.SelectObject(hdcDest, hOld);

            Gdi32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);

            Bitmap bmp = Bitmap.FromHbitmap(hBitmap);
            Gdi32.DeleteObject(hBitmap);

            return bmp;
        }

        private static Image CaptureScreenshotOfRectangle(Rectangle rect)
        {
            IntPtr handle = User32.GetDesktopWindow();

            IntPtr hdcSrc = User32.GetWindowDC(handle);
            IntPtr hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, rect.Width, rect.Height);
            // select the bitmap object
            IntPtr hOld = Gdi32.SelectObject(hdcDest, hBitmap);
            // bitblt over
            Gdi32.BitBlt(hdcDest, 0, 0, rect.Width, rect.Height, hdcSrc, rect.Left, rect.Top, Gdi32.SRCCOPY);
            // restore selection
            Gdi32.SelectObject(hdcDest, hOld);
            // clean up 
            Gdi32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);
            // get a .NET image object for it
            Image img = Image.FromHbitmap(hBitmap);
            // free up the Bitmap object
            Gdi32.DeleteObject(hBitmap);
            return img;
        }

        private static void CapturePeriodicScreenshots()
        {
            // TODO: write me!
        }

        #endregion

        #region Window Manipulation

        public static void SetForegroundWindow(IntPtr handle)
        {
            User32.SetForegroundWindow(handle);
        }

        public static Rectangle GetWindowRectangleFromHandle(IntPtr handle)
        {
            User32.Rect windowRect = new User32.Rect();
            User32.GetWindowRect(handle, ref windowRect);
            return new Rectangle(windowRect.left, windowRect.top, windowRect.right - windowRect.left, windowRect.bottom - windowRect.top);
        }

        #endregion

        #region Validation

        // This method is slow! Only use in non-live testing
        // Checks that the Bitmap is not null,
        // is larger than 1x1, and that it isn't all the same color
        private static bool BitmapIsValid(Bitmap bmp)
        {
            if (bmp == null)
            {
                return false;
            }

            if (bmp.Width <= 1 && bmp.Height <= 1)
            {
                return false;
            }

            bool foundColorMismatch = false;

            Color firstColor = bmp.GetPixel(0, 0);
            for (int x = 0; x < bmp.Width && !foundColorMismatch; x++)
            {
                for (int y = 0; y < bmp.Height && !foundColorMismatch; y++)
                {
                    if (bmp.GetPixel(x, y) != firstColor)
                    {
                        foundColorMismatch = true;
                    }
                }
            }

            if (!foundColorMismatch)
            {
                return false;
            }

            return true;
        }

        #endregion        
    }
}