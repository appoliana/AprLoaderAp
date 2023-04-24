using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Residence
    {
        public Residence()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; } = null!;
        public int? PhoneCode { get; set; }
        public bool Hidden { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
