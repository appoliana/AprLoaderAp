using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Constitution
    {
        public int Id { get; set; }
        public string DicomName { get; set; } = null!;
        public string DicomNameLoc { get; set; } = null!;
    }
}
