using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Department
    {
        public Department()
        {
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public int FactoryId { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual Factory Factory { get; set; } = null!;
        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
