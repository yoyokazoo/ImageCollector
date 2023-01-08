using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace ImageCollector
{
    public static class ImageComparison
    {
        public static List<Point> FindSubImageCoordinates(Bitmap subImage, Bitmap mainImage)
        {
            List<Point> matchingPoints = new List<Point>();

            for (int x = 0; x < mainImage.Width; x++)
            {
                for (int y = 0; y < mainImage.Height; y++)
                {
                    if(SubImageMatches(subImage, mainImage, x, y))
                    {
                        matchingPoints.Add(new Point(x, y));
                    }
                }
                //Console.WriteLine($"Done checking x = {x}");
            }

            return matchingPoints;
        }

        public static bool SubImageMatches(Bitmap subImage, Bitmap mainImage, int x, int y)
        {
            int maxX = x + subImage.Width;
            int maxY = y + subImage.Height;

            // If subImage would exceed the bounds of the main image, we know it can't match
            if (maxX >= mainImage.Width || maxY >= mainImage.Height)
            {
                return false;
            }

            for(int xOffset = 0; xOffset < subImage.Width; xOffset++)
            {
                for(int yOffset = 0; yOffset < subImage.Height; yOffset++)
                {
                    int xToCheck = x + xOffset;
                    int yToCheck = y + yOffset;

                    Color subImageColor = subImage.GetPixel(xOffset, yOffset);
                    Color mainImageColor = mainImage.GetPixel(xToCheck, yToCheck);
                    if (!ColorsAlmostMatch(subImageColor, mainImageColor))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool ColorsAlmostMatch(Color firstColor, Color secondColor, int threshold = 20)
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

        public static List<Tuple<Bitmap, int>> FindUniqueBitmaps(List<Bitmap> sourceBitmaps)
        {
            List<Tuple<Bitmap, int>> uniqueBitmaps = new List<Tuple<Bitmap, int>>();

            foreach (Bitmap bmp in sourceBitmaps)
            {
                var existingTupleIndex = uniqueBitmaps.FindIndex((uniqueBmpTuple) => BitmapEqualsMemCmp(uniqueBmpTuple.Item1, bmp));
                // n^2
                if (existingTupleIndex >= 0)
                {
                    uniqueBitmaps[existingTupleIndex] = new Tuple<Bitmap, int>(uniqueBitmaps[existingTupleIndex].Item1, uniqueBitmaps[existingTupleIndex].Item2 + 1);
                }
                else
                {
                    uniqueBitmaps.Add(new Tuple<Bitmap, int>(bmp, 1));
                }
            }

            return uniqueBitmaps;
        }

        // Taken from: https://stackoverflow.com/questions/2031217/what-is-the-fastest-way-i-can-compare-two-equal-size-bitmaps-to-determine-whethe
        // and https://stackoverflow.com/questions/20372876/a-call-to-pinvoke-function-has-unbalanced-the-stack-this-is-likely-because-the
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int memcmp(IntPtr b1, IntPtr b2, long count);

        public static bool BitmapEqualsMemCmp(Bitmap b1, Bitmap b2)
        {
            if ((b1 == null) != (b2 == null)) return false;
            if (b1.Size != b2.Size) return false;

            var bd1 = b1.LockBits(new Rectangle(new Point(0, 0), b1.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            var bd2 = b2.LockBits(new Rectangle(new Point(0, 0), b2.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                IntPtr bd1scan0 = bd1.Scan0;
                IntPtr bd2scan0 = bd2.Scan0;

                int stride = bd1.Stride;
                int len = stride * b1.Height;

                return memcmp(bd1scan0, bd2scan0, len) == 0;
            }
            finally
            {
                b1.UnlockBits(bd1);
                b2.UnlockBits(bd2);
            }
        }

        // asdf
        public class UniquePixel
        {
            public Point Point { get; set; }
            public Color Color { get; set; }
            public string FilePath { get; set; }

            public override string ToString()
            {
                return $"UniquePixel -- Point: {Point} Color: {Color} FilePath: {FilePath}";
            }
        }

        public static List<Point> FindUniqueColorPoints(string inputFolderPath)
        {
            List<UniquePixel> uniquePixels = new List<UniquePixel>();

            string[] sourceFilePaths = Directory.GetFiles(inputFolderPath);
            List<string> remainingSourceFilePaths = sourceFilePaths.ToList();

            int maxWidth = 0;
            int maxHeight = 0;

            int round = 0;
            List<Bitmap> sourceImages = new List<Bitmap>();

            foreach (string sourceFilePath in sourceFilePaths)
            {
                Bitmap image = new Bitmap(sourceFilePath);
                
                if (maxWidth == 0 && maxHeight == 0)
                {
                    maxWidth = image.Width;
                    maxHeight = image.Height;
                }
                else if(maxWidth != image.Width || maxHeight != image.Height)
                {
                    throw new Exception("Not all images are the same size!");
                }

                sourceImages.Add(new Bitmap(sourceFilePath));
            }

            while (remainingSourceFilePaths.Any())
            {
                round++;
                int minPixelUniqueness = int.MaxValue;
                UniquePixel mostUniquePixel = null;

                for(int x = 0; x < maxWidth; x++)
                {
                    for (int y = 0; y < maxHeight; y++)
                    {
                        Point pixelTuple = new Point(x, y);
                        List<Color> pixelsSeenSoFar = new List<Color>();
                        int pixelDupeCount = 0;
                        List<string> dupes = new List<string>();
                        string mostRecentSourceFilePath = null;
                        Color pixelBeingChecked = Color.Transparent;

                        foreach (string sourceFilePath in remainingSourceFilePaths)
                        {
                            mostRecentSourceFilePath = sourceFilePath;
                            Bitmap image = new Bitmap(sourceFilePath);
                            //UniquePixel pixelBeingChecked = new UniquePixel { Point = pixelTuple, Color = image.GetPixel(x, y), FilePath = sourceFilePath };
                            pixelBeingChecked = image.GetPixel(x, y);

                            UniquePixel uniquePixel = uniquePixels.FirstOrDefault(up => up.Point.Equals(pixelTuple));
                            if (uniquePixel != null && uniquePixel.FilePath.Equals(sourceFilePath))
                            {
                                Console.WriteLine($"Pixel being checked is a 'unique pixel' {pixelTuple}, stored val is {uniquePixel}, my val is {pixelBeingChecked} ({sourceFilePath}).  Skipping.");
                                Console.WriteLine($"Skipping already unique pixel {pixelTuple}");
                                continue;
                            }

                            if (pixelsSeenSoFar.Contains(pixelBeingChecked))
                            {
                                pixelDupeCount++;
                                dupes.Add(sourceFilePath);
                            }
                            else
                            {
                                //Console.WriteLine($"First pixel seen for {pixelTuple} = {pixelBeingChecked} ({sourceFilePath})");
                                pixelsSeenSoFar.Add(pixelBeingChecked);
                            }
                        }

                        if (pixelDupeCount < minPixelUniqueness && uniquePixels.FirstOrDefault(up => up.Point.Equals(pixelTuple)) == null)
                        {
                            Console.WriteLine($"Pixel dupe count for pixel {pixelTuple} = {pixelDupeCount}. Color = {pixelBeingChecked}  Dupes = {string.Join(",", dupes)}");
                            minPixelUniqueness = pixelDupeCount;
                            mostUniquePixel = new UniquePixel { Point = pixelTuple, Color = pixelBeingChecked, FilePath = mostRecentSourceFilePath };
                        }
                        else if (pixelDupeCount == minPixelUniqueness && uniquePixels.FirstOrDefault(up => up.Point.Equals(pixelTuple)) == null)
                        {
                            //Console.WriteLine($"We've found an equally unique pixel.  Let's pick the one that has the color values the furthest from one another. Pixel dupe count for pixel {pixelTuple} = {pixelDupeCount}. Color = {pixelBeingChecked}  Dupes = {string.Join(", ", dupes)}");
                            // Find average pixel color
                            // For each pixel, find the average difference from the average
                            // Pick whichever unique pixel has the highest average difference
                        }
                    }
                }

                Console.WriteLine($"After round {round}, mostUniquePixel = {mostUniquePixel}");

                uniquePixels.Add(mostUniquePixel);

                // since this is more of a preprocessing tool than a runtime tool I haven't focused
                // on performance but if that becomes a concern this could probably be cleaned up
                List<UniquePixel> pixelFrequency = GetSinglePixelFrequency(mostUniquePixel.Point, remainingSourceFilePaths);
                PrintSinglePixelFrequency(mostUniquePixel.Point, pixelFrequency);

                foreach (var pixel in pixelFrequency)
                {
                    remainingSourceFilePaths.Remove(pixel.FilePath);
                }
                Console.WriteLine($"Remaining source file paths ({remainingSourceFilePaths.Count}): {string.Join(",", remainingSourceFilePaths)}");
            }

            return uniquePixels.Select(up => up.Point).ToList();
        }

        public static void PrintUniqueColorPoints(List<Point> uniqueColorPoints)
        {
            IEnumerable<string> uniqueColorPointStrings = uniqueColorPoints.Select(ucp => $"new Point({ucp.X}, {ucp.Y})");
            Console.WriteLine("Unique Color Points:");
            Console.WriteLine($"public static readonly List<Point> _COLOR_POSITIONS = new List<Point> {{ {string.Join(", ", uniqueColorPointStrings)} }};");
        }

        public static void PrintUniqueColorPointsForImages(List<Point> uniqueColorPoints, string inputFolderPath)
        {
            List<string> sourceFilePaths = Directory.GetFiles(inputFolderPath).ToList();
            sourceFilePaths.Sort();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("public static readonly List<List<Color>> _HOLE_CARD_COLORS = new List<List<Color>>");
            sb.AppendLine("{");
            foreach (string sourceFilePath in sourceFilePaths)
            {
                Console.WriteLine(sourceFilePath);
                Bitmap bitmap = new Bitmap(sourceFilePath);
                List<Color> colors = new List<Color>();
                foreach (Point point in uniqueColorPoints)
                {
                    colors.Add(bitmap.GetPixel(point.X, point.Y));
                }

                IEnumerable<string> colorStrings = colors.Select(c => $"Color.FromArgb({c.R}, {c.G}, {c.B})");
                
                sb.AppendLine($"\tnew List<Color> {{ {string.Join(", ", colorStrings)} }},");
            }
            sb.AppendLine("};");
            Console.WriteLine(sb.ToString());
        }

        public static void PrintSinglePixelFrequency(Point pixel, List<UniquePixel> pixelFrequency)
        {
            Console.WriteLine($"Pixel frequency for {pixel}:");
            foreach (var pixelValue in pixelFrequency)
            {
                Console.WriteLine($"\tFrequency of {pixelValue} = 1");
            }
        }

        // returns a list of unqiue pixels with color frequency 1 (aka can be uniquely identified by this point
        public static List<UniquePixel> GetSinglePixelFrequency(Point point, List<string> sourceFilePaths)
        {
            Dictionary<Color, int> pixelFrequency = new Dictionary<Color, int>();
            List<UniquePixel> allUniquePixels = new List<UniquePixel>();

            foreach (string sourceFilePath in sourceFilePaths)
            {
                Bitmap image = new Bitmap(sourceFilePath);
                Color color = image.GetPixel(point.X, point.Y);
                UniquePixel uniquePixel = new UniquePixel { Point = point, Color = color, FilePath = sourceFilePath };
                allUniquePixels.Add(uniquePixel);

                Console.WriteLine($"Pixel value = {color} for image {sourceFilePath}");

                if (pixelFrequency.ContainsKey(color))
                {
                    pixelFrequency[color] = pixelFrequency[color] + 1;
                }
                else
                {
                    pixelFrequency[color] = 1;
                }

                image.Dispose();
            }

            return allUniquePixels.FindAll(up => pixelFrequency[up.Color] == 1);
        }
    }
}