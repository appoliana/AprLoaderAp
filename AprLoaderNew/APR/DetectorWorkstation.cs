using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DetectorWorkstation
    {
        public int Id { get; set; }
        public int LogicalWorkstationId { get; set; }
        public int DetectorId { get; set; }

        public virtual LogicalWorkstation LogicalWorkstation { get; set; } = null!;
    }
}
