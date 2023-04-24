using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GmmSetting
    {
        public int Id { get; set; }
        public int Angle { get; set; }
        public int Speed { get; set; }
        public int TimeToShow { get; set; }
        public string GmmCode { get; set; } = null!;
        public bool IsVisible { get; set; }
    }
}
