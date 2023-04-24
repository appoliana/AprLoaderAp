using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Series
    {
        public Series()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public int StudyId { get; set; }
        public int ExaminationId { get; set; }
        public int LateralityId { get; set; }
        public string Modality { get; set; } = null!;
        public string DicomUid { get; set; } = null!;
        public int? ProjectionId { get; set; }

        public virtual Examination Examination { get; set; } = null!;
        public virtual Laterality Laterality { get; set; } = null!;
        public virtual Projection? Projection { get; set; }
        public virtual Study Study { get; set; } = null!;
        public virtual ICollection<Image> Images { get; set; }
    }
}
