using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class FieldCoefficient
    {
        public int Id { get; set; }
        public bool? IsEnabled { get; set; }
        public int? AecLevel { get; set; }
        public float? Gain { get; set; }
        public int Field { get; set; }
        public int FieldValue { get; set; }
    }
}
