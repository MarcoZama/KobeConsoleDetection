using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBConsoleDetector
{
    public class OnnxOutput
    {
        [ColumnName("model_outputs0")]
        public float[] DetectBoxes { get; set; }
    }
}
