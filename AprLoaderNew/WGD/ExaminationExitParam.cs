using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ExaminationExitParam
    {
        public int Id { get; set; }
        public int RadiationExitTableId { get; set; }
        public int ExaminationId { get; set; }

        public virtual Examination Examination { get; set; } = null!;
        public virtual RadiationExitTable RadiationExitTable { get; set; } = null!;
    }
}
