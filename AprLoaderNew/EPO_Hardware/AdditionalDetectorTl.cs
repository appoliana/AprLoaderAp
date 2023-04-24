using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class AdditionalDetectorTl
    {
        public int Id { get; set; }
        public int DetectorId { get; set; }
        public string Path { get; set; } = null!;
        public int TlsType { get; set; }
        public string CameraName { get; set; } = null!;

        public virtual HardwareDetector Detector { get; set; } = null!;
    }
}
