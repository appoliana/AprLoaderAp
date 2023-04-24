using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class PatientCategory
    {
        public PatientCategory()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
