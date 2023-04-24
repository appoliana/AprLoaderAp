using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class AdditionalParam
    {
        public int Id { get; set; }
        public int AprId { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual Apr Apr { get; set; } = null!;
    }
}
