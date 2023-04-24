using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ImageOriginalParameter
    {
        public int Id { get; set; }
        public double WindowsLevel { get; set; }
        public double WindowsWidth { get; set; }
        public double Gamma { get; set; }
        public int PixelRowNumber { get; set; }
        public int PixelColumnNumber { get; set; }

        public virtual Image IdNavigation { get; set; } = null!;
    }
}
