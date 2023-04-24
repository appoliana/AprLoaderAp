using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class StudyAuxRefBook
    {
        public StudyAuxRefBook()
        {
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual ICollection<Study> Studies { get; set; }
    }
}
