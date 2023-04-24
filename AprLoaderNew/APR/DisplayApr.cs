using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DisplayApr
    {
        public int Id { get; set; }
        public int AprId { get; set; }
        public int RoiId { get; set; }

        public virtual Apr Apr { get; set; } = null!;
    }
}
