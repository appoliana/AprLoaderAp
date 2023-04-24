using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AccessMatrix
    {
        public int Id { get; set; }
        public int ObjGrId { get; set; }
        public int SubjectId { get; set; }
        public int ActionId { get; set; }
        public int? RestrictedRowId { get; set; }
        public int Access { get; set; }

        public virtual AmAction Action { get; set; } = null!;
        public virtual AmObjectGroup ObjGr { get; set; } = null!;
        public virtual AmSubject Subject { get; set; } = null!;
    }
}
