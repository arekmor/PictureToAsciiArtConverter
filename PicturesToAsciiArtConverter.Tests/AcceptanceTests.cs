using System.Diagnostics;
using System.Drawing;
using NUnit.Framework;

namespace PicturesToAsciiArtConverter.Tests
{
    [TestFixture]
    public class AcceptanceTests
    {
        [Test]
        public void BitmapConverterToAscii_DuckyImage_AsciiArt()
        {
            const string filePath = @"D:\Ducky.png";
            const int consoleWidth = 80;
            var bitmap = (Bitmap) Image.FromFile(filePath);

            var convertedBitmap = BitmapTransformations.ResizeToWidth(bitmap, consoleWidth);
            var output = BitmapConverter.ToAscii(convertedBitmap);

            Debug.WriteLine(output);
        }
    }
}