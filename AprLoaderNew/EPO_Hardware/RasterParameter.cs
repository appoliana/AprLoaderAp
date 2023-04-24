using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class RasterParameter
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; } = null!;
        public int FocalDistance { get; set; }
        public int FocalDistanceMin { get; set; }
        public int FocalDistanceMax { get; set; }
        public bool IsEnabled { get; set; }
    }
}
