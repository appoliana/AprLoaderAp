using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class EntityCardAttribute
    {
        public int Id { get; set; }
        public string KeyName { get; set; } = null!;
        public int Position { get; set; }
        public bool Visible { get; set; }
        public bool Editable { get; set; }
        public bool IsMain { get; set; }
        public string Value { get; set; } = null!;
        public int EntityCardType { get; set; }
    }
}
