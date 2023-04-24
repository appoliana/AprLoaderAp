using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Region
    {
        public Region()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
            Residences = new HashSet<Residence>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
        public virtual ICollection<Residence> Residences { get; set; }
    }
}
