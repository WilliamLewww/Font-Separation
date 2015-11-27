using System.Drawing;
using System.Collections.Generic;
using System;

namespace FontSeparation
{
    class FontSeparation
    {
        static Bitmap font;
        public static List<int[]> coordinateList = new List<int[]>();

        public void LoadBitmap(Bitmap bitmap)
        {
            font = bitmap;

            bool a = false, b = false;

            for (int x = 0; x < bitmap.Width; x++)
            {
                b = false;

                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        b = true;
                    }

                    if (y == bitmap.Height - 1 && b == true)
                        a = true;
                    else if (y == bitmap.Height - 1 && b == false)
                        a = false;
                }
            }
        }
    }
}
