using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class DeletedImage
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int SeriesId { get; set; }
        public int? PhysicianId { get; set; }
        public string DicomUid { get; set; } = null!;
        public string Uid { get; set; } = null!;
        public string SopClassUid { get; set; } = null!;
        public double FocalDistance { get; set; }
        public double EntranceDose { get; set; }
        public double Dose { get; set; }
        public int? ContrastId { get; set; }
        public string ExternalFilm { get; set; } = null!;
        public DateTime DeletingDateTime { get; set; }
        public int UserId { get; set; }
        public int StudyId { get; set; }

        public virtual Study Study { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
