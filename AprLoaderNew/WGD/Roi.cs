using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Roi
    {
        public Roi()
        {
            Organs = new HashSet<Organ>();
        }

        public int Id { get; set; }
        public string DicomName { get; set; } = null!;
        public string DicomNameLocalize { get; set; } = null!;

        public virtual ICollection<Organ> Organs { get; set; }
    }
}
