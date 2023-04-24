using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class ExaminationParameter
    {
        public ExaminationParameter()
        {
            Aprs = new HashSet<Apr>();
        }

        public int Id { get; set; }
        public int ExaminationId { get; set; }
        public int? ContrastId { get; set; }
        public int ProjectionId { get; set; }
        public int ConstitutionId { get; set; }
        public int LateralityId { get; set; }
        public string Type { get; set; } = null!;
        public bool Grid { get; set; }
        public string? ImagePath { get; set; }

        public virtual Constitution Constitution { get; set; } = null!;
        public virtual Contrast? Contrast { get; set; }
        public virtual Examination Examination { get; set; } = null!;
        public virtual Laterality Laterality { get; set; } = null!;
        public virtual Projection Projection { get; set; } = null!;
        public virtual ICollection<Apr> Aprs { get; set; }
    }
}
