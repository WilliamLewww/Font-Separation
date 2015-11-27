using System;

namespace FontSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            FontSeparation fontSeparation = new FontSeparation();
            fontSeparation.LoadBitmap(new System.Drawing.Bitmap("font.png"));

            Console.ReadKey();
        }
    }
}
