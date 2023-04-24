using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class TlsDirectory
    {
        public TlsDirectory()
        {
            AprSpecificParameterShotTypeTls = new HashSet<AprSpecificParameter>();
            AprSpecificParameterTlsDirectories = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<AprSpecificParameter> AprSpecificParameterShotTypeTls { get; set; }
        public virtual ICollection<AprSpecificParameter> AprSpecificParameterTlsDirectories { get; set; }
    }
}
