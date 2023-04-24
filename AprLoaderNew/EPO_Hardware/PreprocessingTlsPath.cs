using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class PreprocessingTlsPath
    {
        public int Id { get; set; }
        public int ExposureModeId { get; set; }
        public int ImageSizeId { get; set; }
        public string TlsPath { get; set; } = null!;

        public virtual ExposureMode ExposureMode { get; set; } = null!;
        public virtual ImageSize ImageSize { get; set; } = null!;
    }
}
