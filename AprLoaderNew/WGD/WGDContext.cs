using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AprLoaderNew.Models
{
    public partial class WGDContext : DbContext
    {
        public WGDContext()
        {
        }

        public WGDContext(DbContextOptions<WGDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessMatrix> AccessMatrices { get; set; } = null!;
        public virtual DbSet<AgeGroup> AgeGroups { get; set; } = null!;
        public virtual DbSet<AmAction> AmActions { get; set; } = null!;
        public virtual DbSet<AmObject> AmObjects { get; set; } = null!;
        public virtual DbSet<AmObjectGroup> AmObjectGroups { get; set; } = null!;
        public virtual DbSet<AmOperation> AmOperations { get; set; } = null!;
        public virtual DbSet<AmSubject> AmSubjects { get; set; } = null!;
        public virtual DbSet<AnatomicRegion> AnatomicRegions { get; set; } = null!;
        public virtual DbSet<ArchivedStudy> ArchivedStudies { get; set; } = null!;
        public virtual DbSet<ArchivingCache> ArchivingCaches { get; set; } = null!;
        public virtual DbSet<ArchivingDatum> ArchivingData { get; set; } = null!;
        public virtual DbSet<ArchivingSetting> ArchivingSettings { get; set; } = null!;
        public virtual DbSet<ArchivingStudyStatus> ArchivingStudyStatuses { get; set; } = null!;
        public virtual DbSet<AuxRefBook> AuxRefBooks { get; set; } = null!;
        public virtual DbSet<AuxRefBook01> AuxRefBook01s { get; set; } = null!;
        public virtual DbSet<AuxRefBook02> AuxRefBook02s { get; set; } = null!;
        public virtual DbSet<AuxRefBook03> AuxRefBook03s { get; set; } = null!;
        public virtual DbSet<AuxRefBookJoint> AuxRefBookJoints { get; set; } = null!;
        public virtual DbSet<BackupFilePath> BackupFilePaths { get; set; } = null!;
        public virtual DbSet<CanceledStudy> CanceledStudies { get; set; } = null!;
        public virtual DbSet<CircleShutter> CircleShutters { get; set; } = null!;
        public virtual DbSet<CommonParameter> CommonParameters { get; set; } = null!;
        public virtual DbSet<Constitution> Constitutions { get; set; } = null!;
        public virtual DbSet<Contingent> Contingents { get; set; } = null!;
        public virtual DbSet<Contrast> Contrasts { get; set; } = null!;
        public virtual DbSet<ContrastType> ContrastTypes { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<DefaultEntity> DefaultEntities { get; set; } = null!;
        public virtual DbSet<DeleteRecordLog> DeleteRecordLogs { get; set; } = null!;
        public virtual DbSet<DeletedImage> DeletedImages { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DiagnosisType> DiagnosisTypes { get; set; } = null!;
        public virtual DbSet<DicomModality> DicomModalities { get; set; } = null!;
        public virtual DbSet<DicomService> DicomServices { get; set; } = null!;
        public virtual DbSet<DicomServiceParameter> DicomServiceParameters { get; set; } = null!;
        public virtual DbSet<DicomTransferSyntaxis> DicomTransferSyntaxes { get; set; } = null!;
        public virtual DbSet<DisabledStudy> DisabledStudies { get; set; } = null!;
        public virtual DbSet<EntityCardAttribute> EntityCardAttributes { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<EventLog> EventLogs { get; set; } = null!;
        public virtual DbSet<Examination> Examinations { get; set; } = null!;
        public virtual DbSet<ExaminationExitParam> ExaminationExitParams { get; set; } = null!;
        public virtual DbSet<ExtApp> ExtApps { get; set; } = null!;
        public virtual DbSet<Factory> Factories { get; set; } = null!;
        public virtual DbSet<FilmSize> FilmSizes { get; set; } = null!;
        public virtual DbSet<Hl7serviceParameter> Hl7serviceParameters { get; set; } = null!;
        public virtual DbSet<Hospital> Hospitals { get; set; } = null!;
        public virtual DbSet<HospitalDepartment> HospitalDepartments { get; set; } = null!;
        public virtual DbSet<HospitalType> HospitalTypes { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<ImageCurveType> ImageCurveTypes { get; set; } = null!;
        public virtual DbSet<ImageMultiframeParam> ImageMultiframeParams { get; set; } = null!;
        public virtual DbSet<ImageMultiframeType> ImageMultiframeTypes { get; set; } = null!;
        public virtual DbSet<ImageOpticalParameter> ImageOpticalParameters { get; set; } = null!;
        public virtual DbSet<ImageOriginalParameter> ImageOriginalParameters { get; set; } = null!;
        public virtual DbSet<InsCompany> InsCompanies { get; set; } = null!;
        public virtual DbSet<Laterality> Lateralities { get; set; } = null!;
        public virtual DbSet<LocalDicomParameter> LocalDicomParameters { get; set; } = null!;
        public virtual DbSet<MedicalPosition> MedicalPositions { get; set; } = null!;
        public virtual DbSet<MedicalStaff> MedicalStaffs { get; set; } = null!;
        public virtual DbSet<ModifiedPatient> ModifiedPatients { get; set; } = null!;
        public virtual DbSet<ModifiedPatientHistory> ModifiedPatientHistories { get; set; } = null!;
        public virtual DbSet<Occupation> Occupations { get; set; } = null!;
        public virtual DbSet<Organ> Organs { get; set; } = null!;
        public virtual DbSet<OrganStudyType> OrganStudyTypes { get; set; } = null!;
        public virtual DbSet<PacsMovedImage> PacsMovedImages { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientCategory> PatientCategories { get; set; } = null!;
        public virtual DbSet<PatientDetailed> PatientDetaileds { get; set; } = null!;
        public virtual DbSet<Presentation> Presentations { get; set; } = null!;
        public virtual DbSet<Projection> Projections { get; set; } = null!;
        public virtual DbSet<RadiationExitTable> RadiationExitTables { get; set; } = null!;
        public virtual DbSet<Rank> Ranks { get; set; } = null!;
        public virtual DbSet<RectangleShutter> RectangleShutters { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<ReportsFile> ReportsFiles { get; set; } = null!;
        public virtual DbSet<ReportsFolder> ReportsFolders { get; set; } = null!;
        public virtual DbSet<ReportsInfo> ReportsInfos { get; set; } = null!;
        public virtual DbSet<ReportsSavedFile> ReportsSavedFiles { get; set; } = null!;
        public virtual DbSet<Residence> Residences { get; set; } = null!;
        public virtual DbSet<Risk> Risks { get; set; } = null!;
        public virtual DbSet<Roi> Rois { get; set; } = null!;
        public virtual DbSet<Series> Series { get; set; } = null!;
        public virtual DbSet<Sid> Sids { get; set; } = null!;
        public virtual DbSet<SpecialityType> SpecialityTypes { get; set; } = null!;
        public virtual DbSet<Study> Studies { get; set; } = null!;
        public virtual DbSet<StudyApr> StudyAprs { get; set; } = null!;
        public virtual DbSet<StudyAuxRefBook> StudyAuxRefBooks { get; set; } = null!;
        public virtual DbSet<StudyCancelationReason> StudyCancelationReasons { get; set; } = null!;
        public virtual DbSet<StudyPhysician> StudyPhysicians { get; set; } = null!;
        public virtual DbSet<StudyProtocol> StudyProtocols { get; set; } = null!;
        public virtual DbSet<StudyType> StudyTypes { get; set; } = null!;
        public virtual DbSet<SysInfo> SysInfos { get; set; } = null!;
        public virtual DbSet<SystemParameter> SystemParameters { get; set; } = null!;
        public virtual DbSet<TmpT> TmpTs { get; set; } = null!;
        public virtual DbSet<UnsendedImage> UnsendedImages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<UsersOldPassword> UsersOldPasswords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=WGD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessMatrix>(entity =>
            {
                entity.ToTable("AccessMatrix");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.AccessMatrices)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCESSMA_REFERENCE_AM_ACTIO");

                entity.HasOne(d => d.ObjGr)
                    .WithMany(p => p.AccessMatrices)
                    .HasForeignKey(d => d.ObjGrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCESSMA_REFERENCE_AM_OBJEC");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AccessMatrices)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCESSMA_REFERENCE_AM_SUBJE");
            });

            modelBuilder.Entity<AgeGroup>(entity =>
            {
                entity.ToTable("AgeGroup");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmAction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_AM_ACTION")
                    .IsClustered(false);

                entity.ToTable("AmAction");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmObject>(entity =>
            {
                entity.ToTable("AmObject");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObjGr)
                    .WithMany(p => p.AmObjects)
                    .HasForeignKey(d => d.ObjGrId)
                    .HasConstraintName("FK_AM_OBJEC_REFERENCE_AM_OBJEC");
            });

            modelBuilder.Entity<AmObjectGroup>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmOperation>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmSubject>(entity =>
            {
                entity.ToTable("AmSubject");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnatomicRegion>(entity =>
            {
                entity.ToTable("AnatomicRegion");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodeMeaning)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMeaningLoc)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodingSchemeDesignator)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchivedStudy>(entity =>
            {
                entity.HasOne(d => d.Archive)
                    .WithMany(p => p.ArchivedStudies)
                    .HasForeignKey(d => d.ArchiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_DATA_TO_AR_STUDIES");

                entity.HasOne(d => d.Study)
                    .WithMany(p => p.ArchivedStudies)
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDY_TO_ARCHIVED_STUDIES");
            });

            modelBuilder.Entity<ArchivingCache>(entity =>
            {
                entity.ToTable("ArchivingCache");
            });

            modelBuilder.Entity<ArchivingDatum>(entity =>
            {
                entity.Property(e => e.ArchiveDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiskLabel)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchivingSetting>(entity =>
            {
                entity.Property(e => e.ArchiveDate).HasColumnType("date");

                entity.Property(e => e.Drive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingFolder)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArchivingStudyStatus>(entity =>
            {
                entity.ToTable("ArchivingStudyStatus");
            });

            modelBuilder.Entity<AuxRefBook>(entity =>
            {
                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParamLocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ParamName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TableLocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRefBook01>(entity =>
            {
                entity.ToTable("AuxRefBook01");

                entity.HasIndex(e => e.Param, "IX_AuxRefBook01")
                    .IsUnique();

                entity.Property(e => e.Param)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRefBook02>(entity =>
            {
                entity.ToTable("AuxRefBook02");

                entity.HasIndex(e => e.Param, "IX_AuxRefBook02")
                    .IsUnique();

                entity.Property(e => e.Param)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRefBook03>(entity =>
            {
                entity.ToTable("AuxRefBook03");

                entity.HasIndex(e => e.Param, "IX_AuxRefBook03")
                    .IsUnique();

                entity.Property(e => e.Param)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuxRefBookJoint>(entity =>
            {
                entity.ToTable("AuxRefBookJoint");

                entity.Property(e => e.Hidden).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupFilePath>(entity =>
            {
                entity.ToTable("BackupFilePath");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.BackupFilePaths)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackupFilePath_Image");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BackupFilePaths)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BackupFilePath_User");
            });

            modelBuilder.Entity<CanceledStudy>(entity =>
            {
                entity.ToTable("CanceledStudy");

                entity.HasIndex(e => new { e.StudyId, e.ReasonId }, "IX_CanceledStudy")
                    .IsUnique();
            });

            modelBuilder.Entity<CircleShutter>(entity =>
            {
                entity.ToTable("CircleShutter");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xtranslated).HasColumnName("XTranslated");

                entity.Property(e => e.Ytranslated).HasColumnName("YTranslated");
            });

            modelBuilder.Entity<CommonParameter>(entity =>
            {
                entity.HasIndex(e => e.ParamName, "IX_CommonParameters_2")
                    .IsUnique();

                entity.Property(e => e.Comment)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParamLocName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ParamName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue)
                    .HasMaxLength(2056)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Constitution>(entity =>
            {
                entity.ToTable("Constitution");

                entity.Property(e => e.DicomName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomNameLoc)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contingent>(entity =>
            {
                entity.ToTable("Contingent");

                entity.HasIndex(e => e.Name, "IX_Contingent")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contrast>(entity =>
            {
                entity.ToTable("Contrast");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CodeMeaning)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMeaningLoc)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContrastType>(entity =>
            {
                entity.ToTable("ContrastType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasIndex(e => e.Name, "IX_Country")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefaultEntity>(entity =>
            {
                entity.ToTable("DefaultEntity");

                entity.HasIndex(e => e.EntityName, "UQ__DefaultE__853BB33B1D114BD1")
                    .IsUnique();

                entity.Property(e => e.EntityName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeleteRecordLog>(entity =>
            {
                entity.ToTable("DeleteRecordLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeleteRecordLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeleteRecordLog_User");
            });

            modelBuilder.Entity<DeletedImage>(entity =>
            {
                entity.Property(e => e.DeletingDateTime).HasColumnType("datetime");

                entity.Property(e => e.DicomUid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalFilm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SopClassUid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.HasOne(d => d.Study)
                    .WithMany(p => p.DeletedImages)
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeletedImages_Study");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedImages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deleted_Images_TO_USERS");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.HasIndex(e => new { e.Name, e.FactoryId }, "IX_Department")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEPARTME_REFERENCE_FACTORY");
            });

            modelBuilder.Entity<DiagnosisType>(entity =>
            {
                entity.ToTable("DiagnosisType");

                entity.Property(e => e.DiagnosisType1)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("DiagnosisType");

                entity.Property(e => e.DiagnosisTypeLoc)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicomModality>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicomService>(entity =>
            {
                entity.ToTable("DicomService");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicomServiceParameter>(entity =>
            {
                entity.Property(e => e.AeTitle)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LogicalName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.DicomServiceParameters)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DICOM_SERVICE_TO_PARAMS");

                entity.HasOne(d => d.TransferSyntax)
                    .WithMany(p => p.DicomServiceParameters)
                    .HasForeignKey(d => d.TransferSyntaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRSYN_TO_DICOM_service");
            });

            modelBuilder.Entity<DicomTransferSyntaxis>(entity =>
            {
                entity.Property(e => e.LocName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisabledStudy>(entity =>
            {
                entity.HasIndex(e => e.StudyId, "IX_DisabledStudies")
                    .IsUnique();
            });

            modelBuilder.Entity<EntityCardAttribute>(entity =>
            {
                entity.Property(e => e.KeyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Event1)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Event");

                entity.Property(e => e.LocalizedEvent)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.ToTable("EventLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventLogs)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Event_log_TO_EVENT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EventLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Event_log_TO_USER");
            });

            modelBuilder.Entity<Examination>(entity =>
            {
                entity.ToTable("Examination");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmdName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.AnatomicRegion)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.AnatomicRegionId)
                    .HasConstraintName("FK_Examination_AnatomicRegion");
            });

            modelBuilder.Entity<ExaminationExitParam>(entity =>
            {
                entity.ToTable("ExaminationExitParam");

                entity.HasIndex(e => new { e.ExaminationId, e.RadiationExitTableId }, "IX_ExaminationExitParam")
                    .IsUnique();

                entity.HasOne(d => d.Examination)
                    .WithMany(p => p.ExaminationExitParams)
                    .HasForeignKey(d => d.ExaminationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExaminationExitParam_Examination");

                entity.HasOne(d => d.RadiationExitTable)
                    .WithMany(p => p.ExaminationExitParams)
                    .HasForeignKey(d => d.RadiationExitTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExaminationExitParam_ExaminationExitParam");
            });

            modelBuilder.Entity<ExtApp>(entity =>
            {
                entity.Property(e => e.Hint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factory>(entity =>
            {
                entity.ToTable("Factory");

                entity.HasIndex(e => e.Name, "IX_Factory")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FilmSize>(entity =>
            {
                entity.ToTable("FilmSize");

                entity.HasIndex(e => e.Name, "IX_FilmSize")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hl7serviceParameter>(entity =>
            {
                entity.ToTable("HL7ServiceParameters");

                entity.Property(e => e.Hl7schema)
                    .IsUnicode(false)
                    .HasColumnName("HL7Schema");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LogFilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("Hospital");

                entity.HasIndex(e => e.Name, "IX_Hospital")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HospitalDepartment>(entity =>
            {
                entity.ToTable("HospitalDepartment");

                entity.HasIndex(e => e.Name, "IX_HospitalDepartment")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HospitalType>(entity =>
            {
                entity.ToTable("HospitalType");

                entity.HasIndex(e => e.Name, "IX_HospitalType")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DicomUid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalFilm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FrameCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.ImagePixelSpacing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.ImageType).HasDefaultValueSql("((2))");

                entity.Property(e => e.PostProccesTlsPath)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SopClassUid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.XsubtractionShift).HasColumnName("XSubtractionShift");

                entity.Property(e => e.YsubtractionShift).HasColumnName("YSubtractionShift");

                entity.HasOne(d => d.Contrast)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ContrastId)
                    .HasConstraintName("FK_Image_Contrast");

                entity.HasOne(d => d.CurveType)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.CurveTypeId)
                    .HasConstraintName("FK_Image_ImageCurveType");

                entity.HasOne(d => d.MultiframeType)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.MultiframeTypeId)
                    .HasConstraintName("FK_Image_ImageMultiframeType");

                entity.HasOne(d => d.OpticalParameter)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.OpticalParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_ImageOpticalParameters");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.PhysicianId)
                    .HasConstraintName("FK_Image_MedicalStaff");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_Series");
            });

            modelBuilder.Entity<ImageCurveType>(entity =>
            {
                entity.ToTable("ImageCurveType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageMultiframeParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Levels).HasColumnType("text");

                entity.Property(e => e.Rotate).HasColumnType("text");

                entity.Property(e => e.Windows).HasColumnType("text");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ImageMultiframeParams)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageMultiframeParams_Image");
            });

            modelBuilder.Entity<ImageMultiframeType>(entity =>
            {
                entity.ToTable("ImageMultiframeType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageOpticalParameter>(entity =>
            {
                entity.Property(e => e.Flip).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Landmark).HasDefaultValueSql("((1))");

                entity.Property(e => e.LlateralityIsVisible).HasColumnName("LLateralityIsVisible");

                entity.Property(e => e.LlateralityTranslatedX).HasColumnName("LLateralityTranslatedX");

                entity.Property(e => e.LlateralityTranslatedY).HasColumnName("LLateralityTranslatedY");

                entity.Property(e => e.LlateralityX).HasColumnName("LLateralityX");

                entity.Property(e => e.LlateralityY).HasColumnName("LLateralityY");

                entity.Property(e => e.RlateralityIsVisible).HasColumnName("RLateralityIsVisible");

                entity.Property(e => e.RlateralityTranslatedX).HasColumnName("RLateralityTranslatedX");

                entity.Property(e => e.RlateralityTranslatedY).HasColumnName("RLateralityTranslatedY");

                entity.Property(e => e.RlateralityX).HasColumnName("RLateralityX");

                entity.Property(e => e.RlateralityY).HasColumnName("RLateralityY");

                entity.Property(e => e.Xoffset).HasColumnName("XOffset");

                entity.Property(e => e.Yoffset).HasColumnName("YOffset");

                entity.HasOne(d => d.CircleShutter)
                    .WithMany(p => p.ImageOpticalParameters)
                    .HasForeignKey(d => d.CircleShutterId)
                    .HasConstraintName("FK_ImageOpticalParameters_CircleShutter");

                entity.HasOne(d => d.RectangleShutter)
                    .WithMany(p => p.ImageOpticalParameters)
                    .HasForeignKey(d => d.RectangleShutterId)
                    .HasConstraintName("FK_ImageOpticalParameters_RectangleShutter");
            });

            modelBuilder.Entity<ImageOriginalParameter>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ImageOriginalParameter)
                    .HasForeignKey<ImageOriginalParameter>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageOriginalParameters_Image");
            });

            modelBuilder.Entity<InsCompany>(entity =>
            {
                entity.ToTable("InsCompany");

                entity.HasIndex(e => e.Name, "IX_InsCompany")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Laterality>(entity =>
            {
                entity.ToTable("Laterality");

                entity.Property(e => e.DicomName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomNameLoc)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocalDicomParameter>(entity =>
            {
                entity.Property(e => e.AeTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LocalName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TempFolder)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalPosition>(entity =>
            {
                entity.ToTable("MedicalPosition");

                entity.HasIndex(e => e.Name, "IX_MedicalPosition")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId, "IX_UniqueId")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId).IsRequired();
            });

            modelBuilder.Entity<MedicalStaff>(entity =>
            {
                entity.ToTable("MedicalStaff");

                entity.HasIndex(e => e.Id, "Reference_2_FK");

                entity.Property(e => e.Name)
                    .HasMaxLength(192)
                    .IsUnicode(false);

                entity.Property(e => e.UserInfo).HasColumnType("text");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.MedicalStaffs)
                    .HasPrincipalKey(p => p.UniqueId)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDICAL__REFERENCE_MEDICAL_");
            });

            modelBuilder.Entity<ModifiedPatient>(entity =>
            {
                entity.ToTable("ModifiedPatient");

                entity.Property(e => e.Address)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PassportDate).HasColumnType("datetime");

                entity.Property(e => e.PassportIssuer)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Policy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Surname2)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ModifiedPatients)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Modified_patient_TO_Patient");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ModifiedPatients)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Modified_patient_TO_USER");
            });

            modelBuilder.Entity<ModifiedPatientHistory>(entity =>
            {
                entity.ToTable("ModifiedPatientHistory");

                entity.Property(e => e.Address)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PassportDate).HasColumnType("datetime");

                entity.Property(e => e.PassportIssuer)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Policy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Surname2)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ModifiedPatientHistories)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Modified_patient_history_TO_Patient");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ModifiedPatientHistories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Modified_patient_history_TO_USER");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.ToTable("Occupation");

                entity.HasIndex(e => new { e.Name, e.SpecialityId }, "IX_Occupation")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Occupations)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("FK_TO_SPECIALITY");
            });

            modelBuilder.Entity<Organ>(entity =>
            {
                entity.ToTable("Organ");

                entity.Property(e => e.DicomName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomNameLocalize)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Roi)
                    .WithMany(p => p.Organs)
                    .HasForeignKey(d => d.RoiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGAN_REFERENCE_ROI");
            });

            modelBuilder.Entity<OrganStudyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrganStudyType");

                entity.Property(e => e.OrganId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrganID");

                entity.Property(e => e.StudyTypeId).HasColumnName("StudyTypeID");

                entity.HasOne(d => d.Organ)
                    .WithMany()
                    .HasForeignKey(d => d.OrganId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGAN_ST_REFERENCE_ORGAN");

                entity.HasOne(d => d.StudyType)
                    .WithMany()
                    .HasForeignKey(d => d.StudyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGAN_ST_REFERENCE_STUDY_TY");
            });

            modelBuilder.Entity<PacsMovedImage>(entity =>
            {
                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAetitle)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.PacsMovedImages)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PACS_moved_images_TO_Image");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PacsMovedImages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PACS_moved_images_TO_USER");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasIndex(e => e.Id, "IX_Patient_DICOMID")
                    .IsUnique();

                entity.Property(e => e.AuxPat1)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AuxPat2)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomPatientId)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomUid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('other')");

                entity.Property(e => e.Surname)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Surname2)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Detailed)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DetailedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_PatientDetailed");
            });

            modelBuilder.Entity<PatientCategory>(entity =>
            {
                entity.ToTable("PatientCategory");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientDetailed>(entity =>
            {
                entity.ToTable("PatientDetailed");

                entity.Property(e => e.Address)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Allergies)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.AuxEdit1)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AuxPat3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuxPat4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Constitution).HasDefaultValueSql("((2))");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryNumber)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalAlerts)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PassportDate).HasColumnType("datetime");

                entity.Property(e => e.PassportIssuer)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Policy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgeGroup)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.AgeGroupId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_AGE_GROU");

                entity.HasOne(d => d.AuxEditId2Navigation)
                    .WithMany(p => p.PatientDetailedAuxEditId2Navigations)
                    .HasForeignKey(d => d.AuxEditId2)
                    .HasConstraintName("FK_PatientDetailed_AuxRefBookJoint");

                entity.HasOne(d => d.AuxEditId3Navigation)
                    .WithMany(p => p.PatientDetailedAuxEditId3Navigations)
                    .HasForeignKey(d => d.AuxEditId3)
                    .HasConstraintName("FK_PatientDetailed_AuxRefBookJoint1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_PatientDetailed_PatientCategory");

                entity.HasOne(d => d.Contingent)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.ContingentId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_CONTINGE");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_PatientDetailed_Country");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_DEPARTME");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_PatientDetailed_Factory");

                entity.HasOne(d => d.InsCompany)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.InsCompanyId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_INSCOMPA");

                entity.HasOne(d => d.MilitaryRank)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.MilitaryRankId)
                    .HasConstraintName("FK_PatientDetailed_Ranks");

                entity.HasOne(d => d.Occupation)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.OccupationId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_OCCUPATI");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_PatientDetailed_Region");

                entity.HasOne(d => d.Residence)
                    .WithMany(p => p.PatientDetaileds)
                    .HasForeignKey(d => d.ResidenceId)
                    .HasConstraintName("FK_PATIENT__REFERENCE_RESIDENC");
            });

            modelBuilder.Entity<Presentation>(entity =>
            {
                entity.ToTable("Presentation");

                entity.Property(e => e.Filter).HasColumnType("text");

                entity.Property(e => e.Zoom)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projection>(entity =>
            {
                entity.ToTable("Projection");

                entity.Property(e => e.CodeMeaning)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodingSchemeDesignator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Orientation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewPosition)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RadiationExitTable>(entity =>
            {
                entity.ToTable("RadiationExitTable");

                entity.Property(e => e.ProcedureType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Projection)
                    .WithMany(p => p.RadiationExitTables)
                    .HasForeignKey(d => d.ProjectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RadiationExitTable_Projection");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Ranks")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RectangleShutter>(entity =>
            {
                entity.ToTable("RectangleShutter");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xtranslated).HasColumnName("XTranslated");

                entity.Property(e => e.Ytranslated).HasColumnName("YTranslated");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.HasIndex(e => new { e.Name, e.CountryId }, "IX_Region")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGION_REFERENCE_COUNTRY");
            });

            modelBuilder.Entity<ReportsFile>(entity =>
            {
                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportsFolder>(entity =>
            {
                entity.Property(e => e.ReportsFolder1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ReportsFolder");

                entity.Property(e => e.TemplatesFolder)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportsInfo>(entity =>
            {
                entity.ToTable("ReportsInfo");

                entity.Property(e => e.ReportsRequest).HasColumnType("text");

                entity.Property(e => e.StartExcelCell)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReportsSavedFile>(entity =>
            {
                entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.LastWriteDateTime).HasColumnType("datetime");

                entity.Property(e => e.TillDate).HasColumnType("date");

                entity.HasOne(d => d.ReportTypeNavigation)
                    .WithMany(p => p.ReportsSavedFiles)
                    .HasForeignKey(d => d.ReportType)
                    .HasConstraintName("FK_ReportsSavedFiles_ReportsFiles");
            });

            modelBuilder.Entity<Residence>(entity =>
            {
                entity.ToTable("Residence");

                entity.HasIndex(e => new { e.Name, e.RegionId }, "IX_Residence")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Residences)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESIDENC_REFERENCE_REGION");
            });

            modelBuilder.Entity<Risk>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Risks")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roi>(entity =>
            {
                entity.ToTable("Roi");

                entity.Property(e => e.DicomName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomNameLocalize)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasIndex(e => new { e.StudyId, e.ExaminationId, e.LateralityId, e.Modality, e.DicomUid, e.ProjectionId }, "IX_Unique")
                    .IsUnique();

                entity.Property(e => e.DicomUid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Modality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Examination)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.ExaminationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Series_Examination");

                entity.HasOne(d => d.Laterality)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.LateralityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Series_Laterality");

                entity.HasOne(d => d.Projection)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.ProjectionId)
                    .HasConstraintName("FK_Series_Projection");

                entity.HasOne(d => d.Study)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Series_Study");
            });

            modelBuilder.Entity<Sid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SpecialityType>(entity =>
            {
                entity.ToTable("SpecialityType");

                entity.HasIndex(e => e.Name, "IX_SpecialityType")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Study>(entity =>
            {
                entity.ToTable("Study");

                entity.Property(e => e.AccessionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aux1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Aux2)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Aux3)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Aux4)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diagnosis).HasColumnType("text");

                entity.Property(e => e.DicomId)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DicomUid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FactStartDate).HasColumnType("date");

                entity.Property(e => e.FactStartTime).HasColumnType("time(0)");

                entity.Property(e => e.LastStudyUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.MkbCode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MppsUid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorsName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PlanStartDate).HasColumnType("date");

                entity.Property(e => e.PlanStartTime).HasColumnType("time(0)");

                entity.Property(e => e.PositioningParams)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0;0;0')");

                entity.Property(e => e.PregnancyStatus).HasDefaultValueSql("((4))");

                entity.Property(e => e.ProcedureDescription).HasColumnType("text");

                entity.Property(e => e.SmpName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuxEdit)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.AuxEditId)
                    .HasConstraintName("FK_Study_StudyAuxRefBook");

                entity.HasOne(d => d.AuxEditId2Navigation)
                    .WithMany(p => p.StudyAuxEditId2Navigations)
                    .HasForeignKey(d => d.AuxEditId2)
                    .HasConstraintName("FK_Study_AuxRefBookJoint");

                entity.HasOne(d => d.AuxEditId3Navigation)
                    .WithMany(p => p.StudyAuxEditId3Navigations)
                    .HasForeignKey(d => d.AuxEditId3)
                    .HasConstraintName("FK_Study_AuxRefBookJoint1");

                entity.HasOne(d => d.DiagnosisType)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.DiagnosisTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDY_TO_DIAG_TYPE");

                entity.HasOne(d => d.MppsDicomService)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.MppsDicomServiceId)
                    .HasConstraintName("FK_Study_DICOM_service_parameters");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDY_REFERENCE_PATIENT");

                entity.HasOne(d => d.Protocol)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.ProtocolId)
                    .HasConstraintName("FK_STUDY_REFERENCE_STUDY_PR");

                entity.HasOne(d => d.RefInstitution)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.RefInstitutionId)
                    .HasConstraintName("FK_Study_Hospital");

                entity.HasOne(d => d.RefPhysician)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.RefPhysicianId)
                    .HasConstraintName("FK_Study_Medical_staff");
            });

            modelBuilder.Entity<StudyApr>(entity =>
            {
                entity.ToTable("StudyApr");

                entity.HasOne(d => d.Study)
                    .WithMany(p => p.StudyAprs)
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyApr_Study");
            });

            modelBuilder.Entity<StudyAuxRefBook>(entity =>
            {
                entity.ToTable("StudyAuxRefBook");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudyCancelationReason>(entity =>
            {
                entity.ToTable("StudyCancelationReason");

                entity.HasIndex(e => e.Name, "IX_StudyCancelationReason")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudyPhysician>(entity =>
            {
                entity.HasOne(d => d.MedicalPosition)
                    .WithMany(p => p.StudyPhysicians)
                    .HasPrincipalKey(p => p.UniqueId)
                    .HasForeignKey(d => d.MedicalPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Study_physicians_Medical_position");

                entity.HasOne(d => d.Physician)
                    .WithMany(p => p.StudyPhysicians)
                    .HasForeignKey(d => d.PhysicianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDY_PH_REFERENCE_MEDICAL_");

                entity.HasOne(d => d.Study)
                    .WithMany(p => p.StudyPhysicians)
                    .HasForeignKey(d => d.StudyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDY_PH_REFERENCE_STUDY");
            });

            modelBuilder.Entity<StudyProtocol>(entity =>
            {
                entity.ToTable("StudyProtocol");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudyType>(entity =>
            {
                entity.ToTable("StudyType");

                entity.HasIndex(e => e.Name, "IX_StudyType")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysInfo>(entity =>
            {
                entity.ToTable("SysInfo");

                entity.Property(e => e.Address)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalCode)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ImagesPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wscode).HasColumnName("WSCode");
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__SystemPa__737584F63B0BC30C")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<TmpT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpT");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UnsendedImage>(entity =>
            {
                entity.ToTable("UnsendedImage");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.UnsendedImages)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Unsended_image_Image");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Login, "IX_User_Login")
                    .IsUnique();

                entity.HasIndex(e => e.PhysicianId, "IX_User_PhysicianID")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Reference_3_FK");

                entity.HasIndex(e => e.Id, "Reference_4_FK");

                entity.Property(e => e.LanguageString)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordDate).HasColumnType("datetime");

                entity.HasOne(d => d.AmSubject)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AmSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AMSubject_TO_USER");

                entity.HasOne(d => d.Physician)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.PhysicianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_MedicalStaff");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup");

                entity.HasOne(d => d.AmSubject)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.AmSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_group_TO_AMSubject");
            });

            modelBuilder.Entity<UsersOldPassword>(entity =>
            {
                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersOldPasswords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_TO_Users_old_passwords");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
