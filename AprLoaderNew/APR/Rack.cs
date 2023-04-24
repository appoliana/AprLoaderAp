using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Rack
    {
        public Rack()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public double Column { get; set; }
        public double DetectorShift { get; set; }
        public double Angle { get; set; }
        public double Fdd { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
