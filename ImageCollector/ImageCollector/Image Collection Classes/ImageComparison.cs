using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    }
}
