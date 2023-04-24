using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class Study
    {
        public Study()
        {
            ArchivedStudies = new HashSet<ArchivedStudy>();
            DeletedImages = new HashSet<DeletedImage>();
            Series = new HashSet<Series>();
            StudyAprs = new HashSet<StudyApr>();
            StudyPhysicians = new HashSet<StudyPhysician>();
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int? ProtocolId { get; set; }
        public string DicomUid { get; set; } = null!;
        public string DicomId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? FactStartDate { get; set; }
        public TimeSpan? FactStartTime { get; set; }
        public int StudyStatus { get; set; }
        public string ProcedureDescription { get; set; } = null!;
        public string AccessionNumber { get; set; } = null!;
        public int ImageCount { get; set; }
        public double TotalDose { get; set; }
        public double TotalDoseGr { get; set; }
        public string Status { get; set; } = null!;
        public int? RefInstitutionId { get; set; }
        public int? RefPhysicianId { get; set; }
        public string Diagnosis { get; set; } = null!;
        public DateTime PlanStartDate { get; set; }
        public TimeSpan PlanStartTime { get; set; }
        public int DiagnosisTypeId { get; set; }
        public string Aux1 { get; set; } = null!;
        public string Aux2 { get; set; } = null!;
        public int? AuxEditId { get; set; }
        public DateTime? LastStudyUpdateDate { get; set; }
        public int? ContrastId { get; set; }
        public string MppsUid { get; set; } = null!;
        public bool IsNeedSetMppsStatus { get; set; }
        public int MppsDesiredStatus { get; set; }
        public int? MppsDicomServiceId { get; set; }
        public bool IsSaved { get; set; }
        public string? OperatorsName { get; set; }
        public int PregnancyStatus { get; set; }
        public int? HosDepartmentId { get; set; }
        public string Aux3 { get; set; } = null!;
        public string Aux4 { get; set; } = null!;
        public int? AuxEditId2 { get; set; }
        public int? AuxEditId3 { get; set; }
        public int Source { get; set; }
        public string? SmpName { get; set; }
        public string? MkbCode { get; set; }
        public string PositioningParams { get; set; } = null!;

        public virtual StudyAuxRefBook? AuxEdit { get; set; }
        public virtual AuxRefBookJoint? AuxEditId2Navigation { get; set; }
        public virtual AuxRefBookJoint? AuxEditId3Navigation { get; set; }
        public virtual DiagnosisType DiagnosisType { get; set; } = null!;
        public virtual DicomServiceParameter? MppsDicomService { get; set; }
        public virtual Patient Patient { get; set; } = null!;
        public virtual StudyProtocol? Protocol { get; set; }
        public virtual Hospital? RefInstitution { get; set; }
        public virtual MedicalStaff? RefPhysician { get; set; }
        public virtual ICollection<ArchivedStudy> ArchivedStudies { get; set; }
        public virtual ICollection<DeletedImage> DeletedImages { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<StudyApr> StudyAprs { get; set; }
        public virtual ICollection<StudyPhysician> StudyPhysicians { get; set; }
    }
}
