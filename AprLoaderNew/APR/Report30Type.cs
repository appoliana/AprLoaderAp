using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Report30Type
    {
        public Report30Type()
        {
            Examinations = new HashSet<Examination>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
