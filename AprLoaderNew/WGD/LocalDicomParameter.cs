using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class LocalDicomParameter
    {
        public int Id { get; set; }
        public string AeTitle { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public int Port { get; set; }
        public string LogPath { get; set; } = null!;
        public string TempFolder { get; set; } = null!;
        public string? LocalName { get; set; }
    }
}
