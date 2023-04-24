using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AmObjectGroup
    {
        public AmObjectGroup()
        {
            AccessMatrices = new HashSet<AccessMatrix>();
            AmObjects = new HashSet<AmObject>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LocName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<AccessMatrix> AccessMatrices { get; set; }
        public virtual ICollection<AmObject> AmObjects { get; set; }
    }
}
