using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class RackPreset
    {
        public int Id { get; set; }
        public int PresetCode { get; set; }
        public int ArcTomoMode { get; set; }
        public int ArcArmPosition { get; set; }
        public int? TableTubeAngle { get; set; }
        public int? TableColumnPos { get; set; }
        public int? TableSid { get; set; }
        public int? TomoAngle { get; set; }
        public int? TomoTime { get; set; }
        public int? TomoLayer { get; set; }
        public int? HstandTubeAngle { get; set; }
        public int? HstandHeightDiff { get; set; }
        public int? HstandSid { get; set; }
        public int? VstandTubeAngle { get; set; }
        public int? VstandScolumnPos { get; set; }
        public int? VstandSid { get; set; }
        public string? Name { get; set; }
    }
}
