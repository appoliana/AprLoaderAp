using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class UnsendedImage
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int DicomServiceId { get; set; }
        public int StudyId { get; set; }

        public virtual Image Image { get; set; } = null!;
    }
}
