using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class MedicalPosition
    {
        public MedicalPosition()
        {
            MedicalStaffs = new HashSet<MedicalStaff>();
            StudyPhysicians = new HashSet<StudyPhysician>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }
        public int? UniqueId { get; set; }

        public virtual ICollection<MedicalStaff> MedicalStaffs { get; set; }
        public virtual ICollection<StudyPhysician> StudyPhysicians { get; set; }
    }
}
