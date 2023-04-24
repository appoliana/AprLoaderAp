using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Contrast
    {
        public Contrast()
        {
            ExaminationParameters = new HashSet<ExaminationParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public string CodeMeaning { get; set; } = null!;
        public string CodeMeaningLoc { get; set; } = null!;

        public virtual ICollection<ExaminationParameter> ExaminationParameters { get; set; }
    }
}
