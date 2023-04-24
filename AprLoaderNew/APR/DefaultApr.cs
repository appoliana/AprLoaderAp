using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DefaultApr
    {
        public int Id { get; set; }
        public int ExaminationId { get; set; }
        public int ProjectionId { get; set; }
        public int InnerTypeId { get; set; }
        public int LogicalWorkstationId { get; set; }

        public virtual Examination Examination { get; set; } = null!;
        public virtual LogicalWorkstation LogicalWorkstation { get; set; } = null!;
        public virtual Projection Projection { get; set; } = null!;
    }
}
