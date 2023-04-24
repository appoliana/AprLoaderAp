using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class StudyPhysician
    {
        public int Id { get; set; }
        public int PhysicianId { get; set; }
        public int StudyId { get; set; }
        public int MedicalPositionId { get; set; }

        public virtual MedicalPosition MedicalPosition { get; set; } = null!;
        public virtual MedicalStaff Physician { get; set; } = null!;
        public virtual Study Study { get; set; } = null!;
    }
}
