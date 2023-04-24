using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AuxRefBook
    {
        public int Id { get; set; }
        public string TableName { get; set; } = null!;
        public string TableLocName { get; set; } = null!;
        public string ParamName { get; set; } = null!;
        public string ParamLocName { get; set; } = null!;
        public string Comments { get; set; } = null!;
    }
}
