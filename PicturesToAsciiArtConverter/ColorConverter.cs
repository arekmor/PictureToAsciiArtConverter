using System.Collections.Generic;
using System.Drawing;

namespace PicturesToAsciiArtConverter
{
    public static class ColorConverter
    {
        public static string AsciiForColor(Color inputColor)
        {
            var brightnessToAsciiDictionary = new Dictionary<double, string>
            {
                {0.1, "#"},
                {0.3, "8"},
                {0.5, "o"},
                {0.9, "*"},
                {1.0, " "}
            };

            var asciiOutput = "";

            foreach (var brightessColorPair in brightnessToAsciiDictionary)
            {
                if (inputColor.GetBrightness() <= brightessColorPair.Key)
                {
                    asciiOutput = brightessColorPair.Value;
                    break;
                }                
            }
            return asciiOutput;
        }
    }
}