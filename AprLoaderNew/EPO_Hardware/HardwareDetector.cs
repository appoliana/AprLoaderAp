using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class HardwareDetector
    {
        public HardwareDetector()
        {
            AdditionalDetectorTls = new HashSet<AdditionalDetectorTl>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TlsFilePath { get; set; } = null!;
        public string PreProcessingTlsKey { get; set; } = null!;
        public bool IsUse { get; set; }
        public int DetectorType { get; set; }
        public string UniqueName { get; set; } = null!;
        public string? ImagePixelSpacing { get; set; }
        public string CalibratedImageSize { get; set; } = null!;
        public string? AprVersion { get; set; }

        public virtual ICollection<AdditionalDetectorTl> AdditionalDetectorTls { get; set; }
    }
}
