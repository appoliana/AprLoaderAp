using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Occupation
    {
        public Occupation()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? SpecialityId { get; set; }
        public bool Hidden { get; set; }

        public virtual SpecialityType? Speciality { get; set; }
        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
