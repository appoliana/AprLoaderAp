using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ReportsInfo
    {
        public int Id { get; set; }
        public int ReportsCode { get; set; }
        public string ReportsRequest { get; set; } = null!;
        public string StartExcelCell { get; set; } = null!;
    }
}
