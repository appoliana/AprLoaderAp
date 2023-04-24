using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class AgeGroup
    {
        public AgeGroup()
        {
            Aprs = new HashSet<Apr>();
        }

        public int Id { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Apr> Aprs { get; set; }
    }
}
