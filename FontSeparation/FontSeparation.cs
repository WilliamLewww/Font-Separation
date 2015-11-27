using System.Drawing;
using System.Collections.Generic;

namespace FontSeparation
{
    class FontSeparation
    {
        static Bitmap font;
        public static List<int[]> coordinateList = new List<int[]>();

        public void LoadBitmap(Bitmap bitmap)
        {
            font = bitmap;

            bool a = false;
            int minX = -1, minY = bitmap.Height, maxX = 0, maxY = 0;

            for (int x = 0; x < bitmap.Width; x++)
            {
                a = false;

                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        a = true;

                        if (minX == -1)
                            minX = x;

                        if (y < minY)
                            minY = y;

                        if (x > maxX)
                            maxX = x;

                        if (y > maxY)
                            maxY = y;
                    }
                }

                if (a == false)
                {
                    if (minX != -1)
                        coordinateList.Add(new int[4] { minX, minY, maxX, maxY });

                    minX = -1;
                    minY = bitmap.Height;
                    maxX = 0;
                    maxY = 0;
                }
            }
        }
    }
}
