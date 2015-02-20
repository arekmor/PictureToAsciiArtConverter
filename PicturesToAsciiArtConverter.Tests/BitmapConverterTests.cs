using System;
using System.Drawing;
using NUnit.Framework;

namespace PicturesToAsciiArtConverter.Tests
{
    [TestFixture]
    public class BitmapConverterTests
    {
        [Test]
        public void ToAscii_GivenNull_ReturnsEmptyString()
        {
            var output = BitmapConverter.ToAscii(null);

            Assert.AreEqual(String.Empty, output);
        }
        [Test]
        public void ToAscii_GivenOneYellowPixel_ReturnsOneStar()
        {
            var bitMap = new Bitmap(1, 1);
            bitMap.SetPixel(0, 0, Color.Yellow);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Yellow);

            var output = BitmapConverter.ToAscii(bitMap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenOneWhitePixel_ReturnsOneSpace()
        {
            var bitMap = new Bitmap(1, 1);
            bitMap.SetPixel(0, 0, Color.White);
            var expectedOutput = ColorConverter.AsciiForColor(Color.White);

            var output = BitmapConverter.ToAscii(bitMap);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ToAscii_GivenOneBlackPixel_ReturnsOneHash()
        {
            var bitmap = new Bitmap(1, 1);
            bitmap.SetPixel(0, 0, Color.Black);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Black);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenTwoBlackPixelsInArow_ReturnsHashHash()
        {
            var bitmap = new Bitmap(2, 1);
            bitmap.SetPixel(0, 0, Color.Black);
            bitmap.SetPixel(1, 0, Color.Black);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Black) + ColorConverter.AsciiForColor(Color.Black);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenTwoWhitePixelsInArow_ReturnsSpaceSpace()
        {
            var bitmap = new Bitmap(2, 1);
            bitmap.SetPixel(0, 0, Color.White);
            bitmap.SetPixel(1, 0, Color.White);
            var expectedOutput = ColorConverter.AsciiForColor(Color.White) + ColorConverter.AsciiForColor(Color.White);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenOneBlackPixelAndOneWhitePixelInArow_ReturnsHashSpace()
        {
            var bitmap = new Bitmap(2, 1);
            bitmap.SetPixel(0, 0, Color.Black);
            bitmap.SetPixel(1, 0, Color.White);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Black) + ColorConverter.AsciiForColor(Color.White);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenOneWhitekPixelAndOneBlackPixelInArow_ReturnsSpaceHash()
        {
            var bitmap = new Bitmap(2, 1);
            bitmap.SetPixel(0, 0, Color.White);
            bitmap.SetPixel(1, 0, Color.Black);
            var expectedOutput = ColorConverter.AsciiForColor(Color.White)
                        + ColorConverter.AsciiForColor(Color.Black);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void ToAscii_GivenTwoBlackPixelsInAColumn_ReturnsHashNewLineHash()
        {
            var bitmap = new Bitmap(1, 2);
            bitmap.SetPixel(0, 0, Color.Black);
            bitmap.SetPixel(0, 1, Color.Black);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Black)
                        + Environment.NewLine
                        + ColorConverter.AsciiForColor(Color.Black);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenTwoWhitePixelsInAColumn_ReturnsSpaceNewLineSpace()
        {
            var bitmap = new Bitmap(1, 2);
            bitmap.SetPixel(0, 0, Color.White);
            bitmap.SetPixel(0, 1, Color.White);
            var expectedOutput = ColorConverter.AsciiForColor(Color.White)
                        + Environment.NewLine
                        + ColorConverter.AsciiForColor(Color.White);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenOneBlackPixelAndOneWhitePixelInAColumn_ReturnsHashNewLineSpace()
        {
            var bitmap = new Bitmap(1, 2);
            bitmap.SetPixel(0, 0, Color.Black);
            bitmap.SetPixel(0, 1, Color.White);
            var expectedOutput = ColorConverter.AsciiForColor(Color.Black)
                        + Environment.NewLine
                        + ColorConverter.AsciiForColor(Color.White);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
        [Test]
        public void ToAscii_GivenOneWhitePixelAndOneBlakPixelInAColumn_ReturnsSpaceNewLineHash()
        {
            var bitmap = new Bitmap(1, 2);
            bitmap.SetPixel(0, 0, Color.White);
            bitmap.SetPixel(0, 1, Color.Black);
            var expectedOutput = ColorConverter.AsciiForColor(Color.White)
                        + Environment.NewLine
                        + ColorConverter.AsciiForColor(Color.Black);

            var output = BitmapConverter.ToAscii(bitmap);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}