using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Event
    {
        public Event()
        {
            EventLogs = new HashSet<EventLog>();
        }

        public int Id { get; set; }
        public string Event1 { get; set; } = null!;
        public int Code { get; set; }
        public string LocalizedEvent { get; set; } = null!;

        public virtual ICollection<EventLog> EventLogs { get; set; }
    }
}
