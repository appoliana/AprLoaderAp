using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GeneratorValue
    {
        public GeneratorValue()
        {
            GeneratorValueLimititationDependParams = new HashSet<GeneratorValueLimititation>();
            GeneratorValueLimititationMainParams = new HashSet<GeneratorValueLimititation>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string ParamName { get; set; } = null!;
        public bool Readonly { get; set; }
        public string Value { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string Dimension { get; set; } = null!;
        public string Low { get; set; } = null!;
        public string High { get; set; } = null!;
        public string Step { get; set; } = null!;
        public short Type { get; set; }
        public int ValueTypeId { get; set; }
        public string Values { get; set; } = null!;
        public bool IsMainParameter { get; set; }

        public virtual GeneratorValueType ValueType { get; set; } = null!;
        public virtual ICollection<GeneratorValueLimititation> GeneratorValueLimititationDependParams { get; set; }
        public virtual ICollection<GeneratorValueLimititation> GeneratorValueLimititationMainParams { get; set; }
    }
}
