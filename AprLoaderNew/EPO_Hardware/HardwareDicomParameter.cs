using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class HardwareDicomParameter
    {
        public int Id { get; set; }
        public string ParameterName { get; set; } = null!;
        public string DicomAttribute { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string ParameterComment { get; set; } = null!;
        public string ParameterCommentLocalize { get; set; } = null!;
    }
}
