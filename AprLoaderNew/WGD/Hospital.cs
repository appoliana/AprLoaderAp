using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }

        public virtual ICollection<Study> Studies { get; set; }
    }
}
