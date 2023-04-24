using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class CommonPostProcessingParameter
    {
        public int Id { get; set; }
        public int DetectorId { get; set; }
        public bool HorizontalMirror { get; set; }
        public bool VerticalMirror { get; set; }
        public bool IsInverse { get; set; }
        public int Angle { get; set; }
    }
}
