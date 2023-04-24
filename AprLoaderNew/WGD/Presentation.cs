using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Presentation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageId { get; set; }
        public int WindowLevel { get; set; }
        public int WindowWidth { get; set; }
        public short Inverse { get; set; }
        public short Gamma { get; set; }
        public string Zoom { get; set; } = null!;
        public short Rotation { get; set; }
        public short Mirror { get; set; }
        public string Filter { get; set; } = null!;
    }
}
