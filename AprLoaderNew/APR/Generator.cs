using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Generator
    {
        public Generator()
        {
            AprSpecificParameters = new HashSet<AprSpecificParameter>();
        }

        public int Id { get; set; }
        public int Kv { get; set; }
        public float Mas { get; set; }
        public float Ma { get; set; }
        public int Focus { get; set; }
        public string Grid { get; set; } = null!;
        public int Aec { get; set; }
        public bool IsAecEnabled { get; set; }
        public int Sensity { get; set; }
        public int Density { get; set; }
        public int Technique { get; set; }
        public int? KvScopia { get; set; }
        public float? MaScopia { get; set; }
        public int? BosFramerateId { get; set; }
        public float Ms { get; set; }
        public string? Aecmode { get; set; }
        public string? Aeczone { get; set; }
        public string? Aeclevel { get; set; }

        public virtual ICollection<AprSpecificParameter> AprSpecificParameters { get; set; }
    }
}
