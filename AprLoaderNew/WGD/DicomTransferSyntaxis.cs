using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DicomTransferSyntaxis
    {
        public DicomTransferSyntaxis()
        {
            DicomServiceParameters = new HashSet<DicomServiceParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Code { get; set; }
        public string LocName { get; set; } = null!;

        public virtual ICollection<DicomServiceParameter> DicomServiceParameters { get; set; }
    }
}
