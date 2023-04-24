using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class ModifiedPatient
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public string Surname2 { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string Passport { get; set; } = null!;
        public string PassportIssuer { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumbers { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string Policy { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public int? BirthDateDay { get; set; }
        public int? BirthDateMonth { get; set; }
        public int? BirthDateYear { get; set; }
        public DateTime? PassportDate { get; set; }

        public virtual Patient Patient { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
