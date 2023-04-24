using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GeneratorRelay
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ActivateValue { get; set; }
        public int Code { get; set; }
    }
}
