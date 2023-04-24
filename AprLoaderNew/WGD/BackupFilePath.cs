using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class BackupFilePath
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageId { get; set; }
        public DateTime DateTime { get; set; }
        public string FilePath { get; set; } = null!;
        public int Status { get; set; }

        public virtual Image Image { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
