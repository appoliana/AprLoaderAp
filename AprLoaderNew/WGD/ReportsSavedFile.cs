using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ReportsSavedFile
    {
        public int Id { get; set; }
        public string? FolderName { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime FromDate { get; set; }
        public DateTime? TillDate { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime LastWriteDateTime { get; set; }
        public int? ReportType { get; set; }

        public virtual ReportsFile? ReportTypeNavigation { get; set; }
    }
}
