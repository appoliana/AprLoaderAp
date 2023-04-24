using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Projection
    {
        public Projection()
        {
            RadiationExitTables = new HashSet<RadiationExitTable>();
            Series = new HashSet<Series>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public string CodeMeaning { get; set; } = null!;
        public string CodingSchemeDesignator { get; set; } = null!;
        public string? Orientation { get; set; }
        public string? ViewPosition { get; set; }

        public virtual ICollection<RadiationExitTable> RadiationExitTables { get; set; }
        public virtual ICollection<Series> Series { get; set; }
    }
}
