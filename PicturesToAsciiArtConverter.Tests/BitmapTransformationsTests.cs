using System;
using System.Drawing;
using NUnit.Framework;

namespace PicturesToAsciiArtConverter.Tests
{
    [TestFixture]
    public class BitmapTransformationsTests
    {
        [Test]
        public void ResizeToWidth_GivenBitmapEqualsToNewWidth_ReturnsNotChangedBitmap()
        {
            var bitmap = new Bitmap(5, 5);
            const int newWidth = 5;

            var output = BitmapTransformations.ResizeToWidth(bitmap, newWidth);

            Assert.AreEqual(bitmap.Width, output.Width);
            Assert.AreEqual(bitmap.Height, output.Height);            
        }
        [Test]
        [Sequential]
        public void Resize_GivenBitmapSmallerThanNewWidth_ReturnsResizedBitmap(
            [Values(10, 15, 17)] int newWidth,
            [Values(30, 45, 51)] int expectedHeight)
        {
            var bitmap = new Bitmap(5, 15);

            var output = BitmapTransformations.ResizeToWidth(bitmap, newWidth);

            Assert.AreEqual(newWidth, output.Width);
            Assert.AreEqual(expectedHeight, output.Height);
        }
        [Test]
        [Sequential]
        public void Resize_GivenBitmapLargerThanNewWidth_ReturnsResizedBitmap(
            [Values(5, 4, 1)] int newWidth,
            [Values(10, 8, 2)] int expectedHeight)
        {
            var bitmap = new Bitmap(10, 20);

            var output = BitmapTransformations.ResizeToWidth(bitmap, newWidth);

            Assert.AreEqual(newWidth, output.Width);
            Assert.AreEqual(expectedHeight, output.Height);            
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void Resize_GivenBitmapWithValidSizeAndZeroWidth_ReturnsArgumentException()
        {
            var bitmap = new Bitmap(10, 20);
            const int newWidth = 0;

            BitmapTransformations.ResizeToWidth(bitmap, newWidth);
        }

    }
}