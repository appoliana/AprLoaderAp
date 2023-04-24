using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class RadiationExitTable
    {
        public RadiationExitTable()
        {
            ExaminationExitParams = new HashSet<ExaminationExitParam>();
        }

        public int Id { get; set; }
        public string ProcedureType { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int ProjectionId { get; set; }
        public int FieldSizeH { get; set; }
        public int FieldSizeV { get; set; }
        public int Focus { get; set; }
        public double Umin { get; set; }
        public double Umax { get; set; }
        public double Ke { get; set; }
        public double Kd { get; set; }

        public virtual Projection Projection { get; set; } = null!;
        public virtual ICollection<ExaminationExitParam> ExaminationExitParams { get; set; }
    }
}
