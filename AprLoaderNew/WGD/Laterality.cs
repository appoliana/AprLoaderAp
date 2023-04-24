using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Laterality
    {
        public Laterality()
        {
            Series = new HashSet<Series>();
        }

        public int Id { get; set; }
        public string DicomName { get; set; } = null!;
        public string DicomNameLoc { get; set; } = null!;

        public virtual ICollection<Series> Series { get; set; }
    }
}
