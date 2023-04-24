using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class OrganStudyType
    {
        public int OrganId { get; set; }
        public int StudyTypeId { get; set; }

        public virtual Organ Organ { get; set; } = null!;
        public virtual StudyType StudyType { get; set; } = null!;
    }
}
