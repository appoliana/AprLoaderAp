using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Examination
    {
        public Examination()
        {
            DefaultAprs = new HashSet<DefaultApr>();
            ExaminationParameters = new HashSet<ExaminationParameter>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public int EosTypesId { get; set; }
        public int Report3DozTypesId { get; set; }
        public int Report30TypesId { get; set; }
        public int? AnatomicRegionId { get; set; }
        public string Name { get; set; } = null!;
        public string EmdName { get; set; } = null!;
        public string BodyPart { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public bool Special { get; set; }
        public bool? IsVisible { get; set; }
        public bool IsContrast { get; set; }

        public virtual AnatomicRegion? AnatomicRegion { get; set; }
        public virtual EosType EosTypes { get; set; } = null!;
        public virtual Report30Type Report30Types { get; set; } = null!;
        public virtual Report3DozType Report3DozTypes { get; set; } = null!;
        public virtual ICollection<DefaultApr> DefaultAprs { get; set; }
        public virtual ICollection<ExaminationParameter> ExaminationParameters { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
