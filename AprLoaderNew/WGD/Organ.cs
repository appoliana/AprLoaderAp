using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Organ
    {
        public int Id { get; set; }
        public int RoiId { get; set; }
        public string DicomName { get; set; } = null!;
        public string DicomNameLocalize { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual Roi Roi { get; set; } = null!;
    }
}
