using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class EventLog
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string? Info { get; set; }
        public string? Reason { get; set; }
        public string? ModuleName { get; set; }
        public string? FunctionName { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
