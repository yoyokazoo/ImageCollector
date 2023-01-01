using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
    }
}
