using System.Drawing;

namespace PicturesToAsciiArtConverter
{
    public static class BitmapTransformations
    {
        public static Bitmap ResizeToWidth(Bitmap bitmap, int newWidth)
        {
            var scale = (double)newWidth / bitmap.Width;
            var newHeight = (int)(bitmap.Height * scale);
            var outputBitmap = new Bitmap(bitmap, newWidth, newHeight);
            return outputBitmap;
        }
    }
}