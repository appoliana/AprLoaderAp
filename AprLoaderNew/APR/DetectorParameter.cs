using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DetectorParameter
    {
        public DetectorParameter()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public bool? Dsm { get; set; }
        public int? Dsl { get; set; }

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
