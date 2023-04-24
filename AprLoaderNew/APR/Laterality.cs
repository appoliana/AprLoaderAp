﻿using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Laterality
    {
        public Laterality()
        {
            ExaminationParameters = new HashSet<ExaminationParameter>();
        }

        public int Id { get; set; }
        public string DicomName { get; set; } = null!;
        public string DicomNameLoc { get; set; } = null!;

        public virtual ICollection<ExaminationParameter> ExaminationParameters { get; set; }
    }
}
