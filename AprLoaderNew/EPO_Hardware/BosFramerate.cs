using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class BosFramerate
    {
        public int Id { get; set; }
        public float Speed { get; set; }
        public byte BosParameter { get; set; }
        public double? ImpulsePeriod { get; set; }
        public double? ImpulseTime { get; set; }
    }
}
