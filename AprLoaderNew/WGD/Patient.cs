using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Patient
    {
        public Patient()
        {
            ModifiedPatientHistories = new HashSet<ModifiedPatientHistory>();
            ModifiedPatients = new HashSet<ModifiedPatient>();
            Studies = new HashSet<Study>();
        }

        public int Id { get; set; }
        public int DetailedId { get; set; }
        public string DicomPatientId { get; set; } = null!;
        public string? DicomUid { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public int? BirthDateDay { get; set; }
        public int? BirthDateMonth { get; set; }
        public int? BirthDateYear { get; set; }
        public string Sex { get; set; } = null!;
        public string AuxPat1 { get; set; } = null!;
        public string AuxPat2 { get; set; } = null!;
        public string Surname2 { get; set; } = null!;
        public int DataSource { get; set; }
        public bool IsSaved { get; set; }

        public virtual PatientDetailed Detailed { get; set; } = null!;
        public virtual ICollection<ModifiedPatientHistory> ModifiedPatientHistories { get; set; }
        public virtual ICollection<ModifiedPatient> ModifiedPatients { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
    }
}
