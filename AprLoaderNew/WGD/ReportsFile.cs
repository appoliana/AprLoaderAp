using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ReportsFile
    {
        public ReportsFile()
        {
            ReportsSavedFiles = new HashSet<ReportsSavedFile>();
        }

        public int Id { get; set; }
        public string? LocName { get; set; }
        public string? FileName { get; set; }
        public bool IsForPeriod { get; set; }
        public int Code { get; set; }

        public virtual ICollection<ReportsSavedFile> ReportsSavedFiles { get; set; }
    }
}
