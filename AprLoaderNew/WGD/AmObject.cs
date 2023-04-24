using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AmObject
    {
        public int Id { get; set; }
        public string TableName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public int Tag { get; set; }
        public int? ObjGrId { get; set; }

        public virtual AmObjectGroup? ObjGr { get; set; }
    }
}
