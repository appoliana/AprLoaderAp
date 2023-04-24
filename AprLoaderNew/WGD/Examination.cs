using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Examination
    {
        public Examination()
        {
            ExaminationExitParams = new HashSet<ExaminationExitParam>();
            Series = new HashSet<Series>();
        }

        public int Id { get; set; }
        public int? AnatomicRegionId { get; set; }
        public string Name { get; set; } = null!;
        public string EmdName { get; set; } = null!;
        public string BodyPart { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public bool Special { get; set; }

        public virtual AnatomicRegion? AnatomicRegion { get; set; }
        public virtual ICollection<ExaminationExitParam> ExaminationExitParams { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}
