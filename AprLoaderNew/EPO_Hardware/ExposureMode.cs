using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class ExposureMode
    {
        public ExposureMode()
        {
            PreprocessingTlsPaths = new HashSet<PreprocessingTlsPath>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PreprocessingTlsPath> PreprocessingTlsPaths { get; set; }
    }
}
