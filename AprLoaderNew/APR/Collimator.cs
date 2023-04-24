using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Collimator
    {
        public Collimator()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public string Shape { get; set; } = null!;
        public double Width { get; set; }
        public double Height { get; set; }
        public double Center { get; set; }
        public double Radius { get; set; }
        public int? Filter { get; set; }
        public int? Rotate { get; set; }

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
