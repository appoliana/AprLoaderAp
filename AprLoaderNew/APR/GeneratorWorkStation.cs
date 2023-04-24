using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class GeneratorWorkStation
    {
        public GeneratorWorkStation()
        {
            LogicalWorkstations = new HashSet<LogicalWorkstation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int GeneratorParameterValue { get; set; }
        public bool IsActive { get; set; }
        public bool IsAecEnabled { get; set; }

        public virtual ICollection<LogicalWorkstation> LogicalWorkstations { get; set; }
    }
}
