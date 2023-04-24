using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ArchivedStudy
    {
        public int Id { get; set; }
        public int StudyId { get; set; }
        public int ArchiveId { get; set; }
        public int UserId { get; set; }

        public virtual ArchivingDatum Archive { get; set; } = null!;
        public virtual Study Study { get; set; } = null!;
    }
}
