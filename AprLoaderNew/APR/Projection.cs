using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Projection
    {
        public Projection()
        {
            DefaultAprs = new HashSet<DefaultApr>();
            ExaminationParameters = new HashSet<ExaminationParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public string CodeMeaning { get; set; } = null!;
        public string CodingSchemeDesignator { get; set; } = null!;
        public string Orientation { get; set; } = null!;
        public string ViewPosition { get; set; } = null!;

        public virtual ICollection<DefaultApr> DefaultAprs { get; set; }
        public virtual ICollection<ExaminationParameter> ExaminationParameters { get; set; }
    }
}
