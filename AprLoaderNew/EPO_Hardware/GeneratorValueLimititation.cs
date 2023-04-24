using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GeneratorValueLimititation
    {
        public int Id { get; set; }
        public int MainParamId { get; set; }
        public string MainParamValue { get; set; } = null!;
        public int DependParamId { get; set; }
        public string DependParamValue { get; set; } = null!;

        public virtual GeneratorValue DependParam { get; set; } = null!;
        public virtual GeneratorValue MainParam { get; set; } = null!;
    }
}
