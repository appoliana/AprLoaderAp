using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class ShootingParameter
    {
        public ShootingParameter()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public int? Abs { get; set; }
        public int Diaphragm { get; set; }
        public int? Threshold { get; set; }
        public int? Gain { get; set; }
        public int? Offset { get; set; }
        public bool IsScopy { get; set; }
        public bool IsSerialGraphy { get; set; }
        public bool IsGraphy { get; set; }
        public float Fps { get; set; }
        public float FpsMax { get; set; }
        public int Series { get; set; }
        public int Field { get; set; }

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
