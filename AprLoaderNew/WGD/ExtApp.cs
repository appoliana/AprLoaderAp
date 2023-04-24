using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ExtApp
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Hint { get; set; } = null!;
    }
}
