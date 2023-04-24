using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class SoftwareAprType
    {
        public int Id { get; set; }
        public int AprId { get; set; }
        public int SoftwareInnerTypeId { get; set; }

        public virtual Apr Apr { get; set; } = null!;
        public virtual SoftwareInnerType SoftwareInnerType { get; set; } = null!;
    }
}
