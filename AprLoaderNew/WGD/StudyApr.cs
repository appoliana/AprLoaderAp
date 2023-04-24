using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class StudyApr
    {
        public int Id { get; set; }
        public int StudyId { get; set; }
        public int ExaminationId { get; set; }
        public int ProjectionId { get; set; }

        public virtual Study Study { get; set; } = null!;
    }
}
