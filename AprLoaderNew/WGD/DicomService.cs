using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DicomService
    {
        public DicomService()
        {
            DicomServiceParameters = new HashSet<DicomServiceParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Code { get; set; }

        public virtual ICollection<DicomServiceParameter> DicomServiceParameters { get; set; }
    }
}
