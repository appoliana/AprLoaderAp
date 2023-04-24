using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class SysInfo
    {
        public int Id { get; set; }
        public string HospitalName { get; set; } = null!;
        public string HospitalCode { get; set; } = null!;
        public int Wscode { get; set; }
        public string Version { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public string ImagesPath { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
