using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class UserGroup
    {
        public int Id { get; set; }
        public int AmSubjectId { get; set; }

        public virtual AmSubject AmSubject { get; set; } = null!;
    }
}
