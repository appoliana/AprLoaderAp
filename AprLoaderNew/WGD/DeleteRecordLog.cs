using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DeleteRecordLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ActionDate { get; set; }
        public string TableName { get; set; } = null!;
        public int RecordId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
