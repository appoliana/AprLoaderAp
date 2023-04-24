using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ArchivingSetting
    {
        public int Id { get; set; }
        public long ReqDiskSpace { get; set; }
        public TimeSpan? ArchiveTime { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? DayInMonth { get; set; }
        public bool? LastDayInMonth { get; set; }
        public int? WeekDay { get; set; }
        public bool InProgress { get; set; }
        public string WorkingFolder { get; set; } = null!;
        public int KeepingTime { get; set; }
        public string? Drive { get; set; }
        public int DriveType { get; set; }
        public bool State { get; set; }
    }
}
