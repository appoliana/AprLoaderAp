using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class EosType
    {
        public EosType()
        {
            Examinations = new HashSet<Examination>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
