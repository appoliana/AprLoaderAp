using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class AprSpecificParameter
    {
        public int Id { get; set; }
        public int AprId { get; set; }
        public int CollimatorId { get; set; }
        public int GeneratorId { get; set; }
        public int RackId { get; set; }
        public int DetectorParamId { get; set; }
        public int TlsDirectoryId { get; set; }
        public int ShotTypeTlsId { get; set; }
        public int ShootingParamId { get; set; }
        public int Type { get; set; }
        public int? TomoParameterId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public virtual Apr Apr { get; set; } = null!;
        public virtual Collimator Collimator { get; set; } = null!;
        public virtual DetectorParameter DetectorParam { get; set; } = null!;
        public virtual Generator Generator { get; set; } = null!;
        public virtual Rack Rack { get; set; } = null!;
        public virtual ShootingParameter ShootingParam { get; set; } = null!;
        public virtual TlsDirectory ShotTypeTls { get; set; } = null!;
        public virtual TlsDirectory TlsDirectory { get; set; } = null!;
        public virtual TomoParameter? TomoParameter { get; set; } = null!;
    }
}
