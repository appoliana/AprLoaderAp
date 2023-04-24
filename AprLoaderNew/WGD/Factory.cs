using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Factory
    {
        public Factory()
        {
            Departments = new HashSet<Department>();
            PatientDetaileds = new HashSet<PatientDetailed>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<PatientDetailed> PatientDetaileds { get; set; }
    }
}
