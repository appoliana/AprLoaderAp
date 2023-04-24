using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ArchivingDatum
    {
        public ArchivingDatum()
        {
            ArchivedStudies = new HashSet<ArchivedStudy>();
        }

        public int Id { get; set; }
        public string DiskLabel { get; set; } = null!;
        public DateTime ArchiveDate { get; set; }
        public string? Comments { get; set; }
        public string Folder { get; set; } = null!;

        public virtual ICollection<ArchivedStudy> ArchivedStudies { get; set; }
    }
}
