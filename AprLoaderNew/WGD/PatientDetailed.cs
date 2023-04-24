using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class PatientDetailed
    {
        public PatientDetailed()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public int? AgeGroupId { get; set; }
        public int? CategoryId { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public int? ResidenceId { get; set; }
        public int? FactoryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? OccupationId { get; set; }
        public int? InsCompanyId { get; set; }
        public int? ContingentId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Passport { get; set; } = null!;
        public DateTime? PassportDate { get; set; }
        public string PassportIssuer { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumbers { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string Policy { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public string AuxEdit1 { get; set; } = null!;
        public string HistoryNumber { get; set; } = null!;
        public int Constitution { get; set; }
        public double? TotalDose { get; set; }
        public string? MedicalAlerts { get; set; }
        public string? Allergies { get; set; }
        public int? MilitaryRankId { get; set; }
        public string AuxPat3 { get; set; } = null!;
        public string AuxPat4 { get; set; } = null!;
        public int? AuxEditId2 { get; set; }
        public int? AuxEditId3 { get; set; }

        public virtual AgeGroup? AgeGroup { get; set; }
        public virtual AuxRefBookJoint? AuxEditId2Navigation { get; set; }
        public virtual AuxRefBookJoint? AuxEditId3Navigation { get; set; }
        public virtual PatientCategory? Category { get; set; }
        public virtual Contingent? Contingent { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Factory? Factory { get; set; }
        public virtual InsCompany? InsCompany { get; set; }
        public virtual Rank? MilitaryRank { get; set; }
        public virtual Occupation? Occupation { get; set; }
        public virtual Region? Region { get; set; }
        public virtual Residence? Residence { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
