using System;
using System.Collections.Generic;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class ImageSize
    {
        public ImageSize()
        {
            PreprocessingTlsPaths = new HashSet<PreprocessingTlsPath>();
        }

        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual ICollection<PreprocessingTlsPath> PreprocessingTlsPaths { get; set; }
    }
}
