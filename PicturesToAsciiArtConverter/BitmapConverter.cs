using System;
using System.Drawing;
using System.Text;

namespace PicturesToAsciiArtConverter
{
    public static class BitmapConverter
    {
        public static string ToAscii(Bitmap bitmapToConvert)
        {
            if (bitmapToConvert == null)
            {
                return String.Empty;
            }

            var result = new StringBuilder();
            for (var y = 0; y < bitmapToConvert.Height; y++)
            {
                for (var x = 0; x < bitmapToConvert.Width; x++)
                {                   
                    result.Append(AsciiForPixel(bitmapToConvert, x, y));
                }
                var lastItemInLine = bitmapToConvert.Height - 1;
                if (y != lastItemInLine)
                    result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        private static String AsciiForPixel(Bitmap bitmapToConvert, int x, int y)
        {
            var color = bitmapToConvert.GetPixel(x, y);
            return ColorConverter.AsciiForColor(color);
        }
    }
}
