using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Hl7serviceParameter
    {
        public int Id { get; set; }
        public string Hl7schema { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public int Port { get; set; }
        public int Timeout { get; set; }
        public string? LogFilePath { get; set; }
    }
}
