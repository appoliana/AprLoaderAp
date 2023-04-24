using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ImageMultiframeParam
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public string Windows { get; set; } = null!;
        public string Levels { get; set; } = null!;
        public string Rotate { get; set; } = null!;

        public virtual Image Image { get; set; } = null!;
    }
}
