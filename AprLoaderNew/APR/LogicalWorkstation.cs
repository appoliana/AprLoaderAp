using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class LogicalWorkstation
    {
        public LogicalWorkstation()
        {
            Aprs = new HashSet<Apr>();
            DefaultAprs = new HashSet<DefaultApr>();
        }

        public int Id { get; set; }
        public int WorkstationId { get; set; }
        public bool IsTomo { get; set; }
        public bool IsScopy { get; set; }
        public bool IsSerialGraphy { get; set; }
        public bool IsFilm { get; set; }
        public bool IsAecEnabled { get; set; }
        public string UniqueName { get; set; } = null!;
        public string ToolTip { get; set; } = null!;
        public bool? IsVisible { get; set; }
        public int UniqueId { get; set; }
        public bool IsRaster { get; set; }
        public int DosimeterId { get; set; }

        public virtual GeneratorWorkStation Workstation { get; set; } = null!;
        public virtual ICollection<Apr> Aprs { get; set; }
        public virtual ICollection<DefaultApr> DefaultAprs { get; set; }
    }
}
