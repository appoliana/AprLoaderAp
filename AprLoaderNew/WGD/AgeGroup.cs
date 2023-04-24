using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AgeGroup
    {
        public AgeGroup()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Max { get; set; }
        public double Min { get; set; }

        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
