using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Contrast
    {
        public Contrast()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CodeValue { get; set; } = null!;
        public string CodeMeaning { get; set; } = null!;
        public string CodeMeaningLoc { get; set; } = null!;
        public int? ContrastTypeId { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
