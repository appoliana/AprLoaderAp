using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class HospitalDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Hidden { get; set; }
    }
}
