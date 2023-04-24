using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AuxRefBookJoint
    {
        public AuxRefBookJoint()
        {
            PatientDetailedAuxEditId2Navigations = new HashSet<PatientDetailed>();
            PatientDetailedAuxEditId3Navigations = new HashSet<PatientDetailed>();
            StudyAuxEditId2Navigations = new HashSet<Study>();
            StudyAuxEditId3Navigations = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string KeyName { get; set; } = null!;
        public string? Value { get; set; }
        public bool? Hidden { get; set; }

        public virtual ICollection<PatientDetailed> PatientDetailedAuxEditId2Navigations { get; set; }
        public virtual ICollection<PatientDetailed> PatientDetailedAuxEditId3Navigations { get; set; }
        public virtual ICollection<Study> StudyAuxEditId2Navigations { get; set; }
        public virtual ICollection<Study> StudyAuxEditId3Navigations { get; set; }
    }
}
