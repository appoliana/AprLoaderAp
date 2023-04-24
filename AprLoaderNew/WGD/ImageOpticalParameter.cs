using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ImageOpticalParameter
    {
        public ImageOpticalParameter()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public double Xoffset { get; set; }
        public double Yoffset { get; set; }
        public double Scale { get; set; }
        public int? CircleShutterId { get; set; }
        public int? RectangleShutterId { get; set; }
        public double Window { get; set; }
        public double Level { get; set; }
        public double Gamma { get; set; }
        public bool LlateralityIsVisible { get; set; }
        public bool RlateralityIsVisible { get; set; }
        public double LlateralityX { get; set; }
        public double LlateralityY { get; set; }
        public double RlateralityX { get; set; }
        public double RlateralityY { get; set; }
        public int? LateralityAngle { get; set; }
        public double LlateralityTranslatedX { get; set; }
        public double LlateralityTranslatedY { get; set; }
        public double RlateralityTranslatedX { get; set; }
        public double RlateralityTranslatedY { get; set; }
        public int? ShutterAngle { get; set; }
        public int Rotate { get; set; }
        public int Flip { get; set; }
        public bool? IsInverse { get; set; }
        public bool Substraction { get; set; }
        public int? MaskFrameNumber { get; set; }
        public int HorizontalPixelShift { get; set; }
        public int VerticalPixelShift { get; set; }
        public double Landmark { get; set; }
        public byte[]? OverlayData { get; set; }

        public virtual CircleShutter? CircleShutter { get; set; }
        public virtual RectangleShutter? RectangleShutter { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
