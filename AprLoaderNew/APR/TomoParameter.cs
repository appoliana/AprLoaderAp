using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class TomoParameter
    {
        public TomoParameter()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public int CuttingHeight { get; set; }
        public int SwivelAngle { get; set; }
        public int ShootingTime { get; set; }

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
