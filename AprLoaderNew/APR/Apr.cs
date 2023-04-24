using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Apr
    {
        public Apr()
        {
            AdditionalParams = new HashSet<AdditionalParam>();
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
            DisplayAprs = new HashSet<DisplayApr>();
            SoftwareAprTypes = new HashSet<SoftwareAprType>();
        }

        public int Id { get; set; }
        public int ExaminationParamId { get; set; }
        public int DetectorTypeId { get; set; }
        public int AgeId { get; set; }
        public string Name { get; set; } = null!;
        public string AuxTex { get; set; } = null!;
        public int AuxInt { get; set; }
        public double AuxFloat { get; set; }
        public bool IsOriginal { get; set; }
        public int UserId { get; set; }
        public int AprType { get; set; }
        public int? StandCode { get; set; }
        public int LogicalWorkstationId { get; set; }
        public int? ComplexType { get; set; }

        public virtual AgeGroup Age { get; set; } = null!;
        public virtual DetectorType DetectorType { get; set; } = null!;
        public virtual ExaminationParameter ExaminationParam { get; set; } = null!;
        public virtual LogicalWorkstation LogicalWorkstation { get; set; } = null!;
        public virtual ICollection<AdditionalParam> AdditionalParams { get; set; }
        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
        public virtual ICollection<DisplayApr> DisplayAprs { get; set; }
        public virtual ICollection<SoftwareAprType> SoftwareAprTypes { get; set; }
    }
}
