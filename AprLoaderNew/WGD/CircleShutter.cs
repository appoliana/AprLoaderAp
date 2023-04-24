using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class CircleShutter
    {
        public CircleShutter()
        {
            ImageOpticalParameters = new HashSet<ImageOpticalParameter>();
        }

        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        public string Color { get; set; } = null!;
        public double Xtranslated { get; set; }
        public double Ytranslated { get; set; }

        public virtual ICollection<ImageOpticalParameter> ImageOpticalParameters { get; set; }
    }
}
