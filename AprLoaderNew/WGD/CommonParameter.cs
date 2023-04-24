using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class CommonParameter
    {
        public int Id { get; set; }
        public string ParamName { get; set; } = null!;
        public string ParamValue { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string ParamLocName { get; set; } = null!;
        public bool? IsVisible { get; set; }
    }
}
