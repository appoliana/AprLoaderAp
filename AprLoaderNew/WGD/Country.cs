using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Country
    {
        public Country()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
            Regions = new HashSet<Region>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
