using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ArchivingCache
    {
        public int Id { get; set; }
        public int StudyId { get; set; }
        public long Size { get; set; }
        public int OldStatus { get; set; }
        public int PatientId { get; set; }
    }
}
