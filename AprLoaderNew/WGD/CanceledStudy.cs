using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class CanceledStudy
    {
        public int Id { get; set; }
        public int StudyId { get; set; }
        public int ReasonId { get; set; }
    }
}
