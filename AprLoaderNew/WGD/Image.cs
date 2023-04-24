using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Image
    {
        public Image()
        {
            BackupFilePaths = new HashSet<BackupFilePath>();
            ImageMultiframeParams = new HashSet<ImageMultiframeParam>();
            PacsMovedImages = new HashSet<PacsMovedImage>();
            UnsendedImages = new HashSet<UnsendedImage>();
        }

        public int Id { get; set; }
        public int OpticalParameterId { get; set; }
        public int SeriesId { get; set; }
        public int? PhysicianId { get; set; }
        public int? ContrastId { get; set; }
        public string DicomUid { get; set; } = null!;
        public string Uid { get; set; } = null!;
        public string SopClassUid { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public double FocalDistance { get; set; }
        public double EntranceDose { get; set; }
        public double Dose { get; set; }
        public string ExternalFilm { get; set; } = null!;
        public byte[] ImagePreview { get; set; } = null!;
        public long FileSize { get; set; }
        public DateTime DateCreation { get; set; }
        public int Status { get; set; }
        public int? Kv { get; set; }
        public double? Ma { get; set; }
        public double? Ms { get; set; }
        public double? Mas { get; set; }
        public double? DoseIndicator { get; set; }
        public double? DoseIndicatorDeviation { get; set; }
        public int? DoseIndicatorResult { get; set; }
        public int? MultiframeTypeId { get; set; }
        public double FrameRate { get; set; }
        public int? CurveTypeId { get; set; }
        public bool HightQuality { get; set; }
        public bool IsFilm { get; set; }
        public string PostProccesTlsPath { get; set; } = null!;
        public string? Comment { get; set; }
        public int MaskFrameNumber { get; set; }
        public bool IsSubtractionEnabled { get; set; }
        public int XsubtractionShift { get; set; }
        public int YsubtractionShift { get; set; }
        public double Landmark { get; set; }
        public int ImageType { get; set; }
        public int? TomoLayerHeight { get; set; }
        public int? FluoroKv { get; set; }
        public double? FluoroMa { get; set; }
        public int? TubeHeat { get; set; }
        public int? ReopField { get; set; }
        public string? ImagePixelSpacing { get; set; }
        public int? PredefKv { get; set; }
        public double? PredefMas { get; set; }
        public double? PredefMs { get; set; }
        public double? PredefMa { get; set; }
        public bool? PredefIsAecEn { get; set; }
        public int? PredefAec { get; set; }
        public int? PredefDensity { get; set; }
        public int FrameCount { get; set; }
        public double? TomoTime { get; set; }
        public double? TomoAngle { get; set; }

        public virtual Contrast? Contrast { get; set; }
        public virtual ImageCurveType? CurveType { get; set; }
        public virtual ImageMultiframeType? MultiframeType { get; set; }
        public virtual ImageOpticalParameter OpticalParameter { get; set; } = null!;
        public virtual MedicalStaff? Physician { get; set; }
        public virtual Series Series { get; set; } = null!;
        public virtual ImageOriginalParameter ImageOriginalParameter { get; set; } = null!;
        public virtual ICollection<BackupFilePath> BackupFilePaths { get; set; }
        public virtual ICollection<ImageMultiframeParam> ImageMultiframeParams { get; set; }
        public virtual ICollection<PacsMovedImage> PacsMovedImages { get; set; }
        public virtual ICollection<UnsendedImage> UnsendedImages { get; set; }
    }
}
