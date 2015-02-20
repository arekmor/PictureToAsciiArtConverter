using System.Drawing;
using NUnit.Framework;

namespace PicturesToAsciiArtConverter.Tests
{
    [TestFixture]
    public class ColorConverterTests
    {

        [Test]
        public void AsciiForColor_GivenColorBlack_ReturnsHash()
        {
            var output = ColorConverter.AsciiForColor(Color.Black);

            Assert.AreEqual("#", output);
        }
        [Test]
        public void AsciiForColor_GivenColorWhite_ReturnsSpace()
        {
            var output = ColorConverter.AsciiForColor(Color.White);

            Assert.AreEqual(" ", output);
        }
        [Test]
        public void AsciiForColor_GivenColorYellow_ReturnsSmallLetterO()
        {
            var output = ColorConverter.AsciiForColor(Color.Yellow);

            Assert.AreEqual("o", output);
        } 
    }
}