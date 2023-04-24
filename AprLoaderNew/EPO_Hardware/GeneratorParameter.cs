using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class GeneratorParameter
    {
        public int Id { get; set; }
        public string GeneratorType { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Guid { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
