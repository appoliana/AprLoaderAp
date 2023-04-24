using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class SystemParameter
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public string? Description { get; set; }
    }
}
