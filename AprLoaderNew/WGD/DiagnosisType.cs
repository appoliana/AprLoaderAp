using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DiagnosisType
    {
        public DiagnosisType()
        {
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string DiagnosisType1 { get; set; } = null!;
        public string DiagnosisTypeLoc { get; set; } = null!;
        public int Code { get; set; }
        public bool Hidden { get; set; }

        public virtual ICollection<Study> Studies { get; set; }
    }
}
