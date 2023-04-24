using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class DoseMultiplier
    {
        public int Id { get; set; }
        public int ExaminationParamId { get; set; }
        public int AgeGroupId { get; set; }
        public double Multiplier { get; set; }
    }
}
