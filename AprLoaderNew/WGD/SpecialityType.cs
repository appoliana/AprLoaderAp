using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class SpecialityType
    {
        public SpecialityType()
        {
            Occupations = new HashSet<Occupation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual ICollection<Occupation> Occupations { get; set; }
    }
}
