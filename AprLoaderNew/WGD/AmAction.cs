using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AmAction
    {
        public AmAction()
        {
            AccessMatrices = new HashSet<AccessMatrix>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LocName { get; set; } = null!;
        public string? Description { get; set; }
        public int Code { get; set; }

        public virtual ICollection<AccessMatrix> AccessMatrices { get; set; }
    }
}
