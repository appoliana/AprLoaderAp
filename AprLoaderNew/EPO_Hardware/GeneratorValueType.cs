using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GeneratorValueType
    {
        public GeneratorValueType()
        {
            GeneratorValues = new HashSet<GeneratorValue>();
        }

        public int Id { get; set; }
        public string ParameterType { get; set; } = null!;

        public virtual ICollection<GeneratorValue> GeneratorValues { get; set; }
    }
}
