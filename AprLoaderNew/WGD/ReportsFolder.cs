using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ReportsFolder
    {
        public int Id { get; set; }
        public string TemplatesFolder { get; set; } = null!;
        public string ReportsFolder1 { get; set; } = null!;
    }
}
