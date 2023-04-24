using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AnatomicRegion
    {
        public AnatomicRegion()
        {
            Examinations = new HashSet<Examination>();
        }

        public int Id { get; set; }
        public string CodeValue { get; set; } = null!;
        public string CodeMeaning { get; set; } = null!;
        public string CodeMeaningLoc { get; set; } = null!;
        public string CodingSchemeDesignator { get; set; } = null!;

        public virtual ICollection<Examination> Examinations { get; set; }
    }
}
