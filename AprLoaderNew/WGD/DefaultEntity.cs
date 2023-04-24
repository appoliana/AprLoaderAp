using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DefaultEntity
    {
        public int Id { get; set; }
        public string EntityName { get; set; } = null!;
        public int EntityId { get; set; }
    }
}
