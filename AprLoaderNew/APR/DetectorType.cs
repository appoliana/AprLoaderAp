using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DetectorType
    {
        public DetectorType()
        {
            Aprs = new HashSet<Apr>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Type { get; set; }

        public virtual ICollection<Apr> Aprs { get; set; }
    }
}
