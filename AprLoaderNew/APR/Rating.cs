using System;
using System.Collections.Generic;

namespace AprLoaderNew.APR
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int ExaminationId { get; set; }

        public virtual Examination Examination { get; set; } = null!;
    }
}
