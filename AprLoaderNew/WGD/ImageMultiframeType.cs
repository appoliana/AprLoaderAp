using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ImageMultiframeType
    {
        public ImageMultiframeType()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Image> Images { get; set; }
    }
}
