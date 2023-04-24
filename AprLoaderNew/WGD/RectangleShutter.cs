using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class RectangleShutter
    {
        public RectangleShutter()
        {
            ImageOpticalParameters = new HashSet<ImageOpticalParameter>();
        }

        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; } = null!;
        public double Xtranslated { get; set; }
        public double Ytranslated { get; set; }
        public double WidthTranslated { get; set; }
        public double HeightTranslated { get; set; }

        public virtual ICollection<ImageOpticalParameter> ImageOpticalParameters { get; set; }
    }
}
