using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Report3DozType
    {
        public Report3DozType()
        {
            Examinations = new HashSet<Examination>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
