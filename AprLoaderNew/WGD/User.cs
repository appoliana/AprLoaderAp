using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class User
    {
        public User()
        {
            BackupFilePaths = new HashSet<BackupFilePath>();
            DeleteRecordLogs = new HashSet<DeleteRecordLog>();
            DeletedImages = new HashSet<DeletedImage>();
            EventLogs = new HashSet<EventLog>();
            ModifiedPatientHistories = new HashSet<ModifiedPatientHistory>();
            ModifiedPatients = new HashSet<ModifiedPatient>();
            PacsMovedImages = new HashSet<PacsMovedImage>();
            UsersOldPasswords = new HashSet<UsersOldPassword>();
        }

        public int Id { get; set; }
        public int PhysicianId { get; set; }
        public int UserGroupId { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int AmSubjectId { get; set; }
        public bool IsBlocked { get; set; }
        public bool Last { get; set; }
        public int PasswordPeriod { get; set; }
        public DateTime PasswordDate { get; set; }
        public string? LanguageString { get; set; }

        public virtual AmSubject AmSubject { get; set; } = null!;
        public virtual MedicalStaff Physician { get; set; } = null!;
        public virtual ICollection<BackupFilePath> BackupFilePaths { get; set; }
        public virtual ICollection<DeleteRecordLog> DeleteRecordLogs { get; set; }
        public virtual ICollection<DeletedImage> DeletedImages { get; set; }
        public virtual ICollection<EventLog> EventLogs { get; set; }
        public virtual ICollection<ModifiedPatientHistory> ModifiedPatientHistories { get; set; }
        public virtual ICollection<ModifiedPatient> ModifiedPatients { get; set; }
        public virtual ICollection<PacsMovedImage> PacsMovedImages { get; set; }
        public virtual ICollection<UsersOldPassword> UsersOldPasswords { get; set; }
    }
}
