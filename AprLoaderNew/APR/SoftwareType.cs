using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class SoftwareType
    {
        public SoftwareType()
        {
            SoftwareInnerTypes = new HashSet<SoftwareInnerType>();
        }

        public int Id { get; set; }
        public int UniqueId { get; set; }
        public string Comment { get; set; } = null!;

        public virtual ICollection<SoftwareInnerType> SoftwareInnerTypes { get; set; }
    }
}
