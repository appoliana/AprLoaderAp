using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class UpsParameter
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Guid { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? Name { get; set; }
        public string? ConnectionString { get; set; }
    }
}
