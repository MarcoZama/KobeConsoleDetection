using Microsoft.ML.Transforms.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBConsoleDetector
{
    public class OnnxInput
    {
        [ImageType(ImageSettings.imageHeight, ImageSettings.imageWidth)]
        public Bitmap ImagePath { get; set; }
    }

    public struct ImageSettings
    {
        public const int imageHeight = 416;
        public const int imageWidth = 416;
    }
}
