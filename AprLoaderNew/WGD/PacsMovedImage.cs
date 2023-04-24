using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class PacsMovedImage
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string ReceiverAetitle { get; set; } = null!;

        public virtual Image Image { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
