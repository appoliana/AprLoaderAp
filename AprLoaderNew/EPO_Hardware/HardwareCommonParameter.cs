using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class HardwareCommonParameter
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public string Description { get; set; } = null!;
    }
}
