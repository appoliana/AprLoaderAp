using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DicomServiceParameter
    {
        public DicomServiceParameter()
        {
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string LogicalName { get; set; } = null!;
        public string AeTitle { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public int Port { get; set; }
        public int PduSize { get; set; }
        public int Timeout { get; set; }
        public int? ListenPort { get; set; }
        public int ServiceId { get; set; }
        public bool Status { get; set; }
        public int ServiceRole { get; set; }
        public int TransferSyntaxId { get; set; }
        public bool EnableLog { get; set; }
        public string? FilePath { get; set; }
        public int? AssocNumber { get; set; }

        public virtual DicomService Service { get; set; } = null!;
        public virtual DicomTransferSyntaxis TransferSyntax { get; set; } = null!;
        public virtual ICollection<Study> Studies { get; set; }
    }
}
