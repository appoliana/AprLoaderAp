using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class SoftwareInnerType
    {
        public SoftwareInnerType()
        {
            SoftwareAprTypes = new HashSet<SoftwareAprType>();
        }

        public int Id { get; set; }
        public int SoftwareTypeId { get; set; }
        public int UniqueId { get; set; }
        public string Comment { get; set; } = null!;

        public virtual SoftwareType SoftwareType { get; set; } = null!;
        public virtual ICollection<SoftwareAprType> SoftwareAprTypes { get; set; }
    }
}
