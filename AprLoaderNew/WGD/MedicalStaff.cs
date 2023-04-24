using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class MedicalStaff
    {
        public MedicalStaff()
        {
            Images = new HashSet<Image>();
            Studies = new HashSet<Study>();
            StudyPhysicians = new HashSet<StudyPhysician>();
        }

        public int Id { get; set; }
        public int PositionId { get; set; }
        public string Name { get; set; } = null!;
        public string UserInfo { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual MedicalPosition Position { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
        public virtual ICollection<StudyPhysician> StudyPhysicians { get; set; }
    }
}
