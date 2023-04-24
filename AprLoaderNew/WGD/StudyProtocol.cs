using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class StudyProtocol
    {
        public StudyProtocol()
        {
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Study> Studies { get; set; }
    }
}
