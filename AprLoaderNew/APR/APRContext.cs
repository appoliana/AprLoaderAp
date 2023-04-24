using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AprLoaderNew.APR
{
    public partial class APRContext : DbContext
    {
        public APRContext()
        {
        }

        public APRContext(DbContextOptions<APRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalParam> AdditionalParams { get; set; } = null!;
        public virtual DbSet<AgeGroup> AgeGroups { get; set; } = null!;
        public virtual DbSet<AnatomicRegion> AnatomicRegions { get; set; } = null!;
        public virtual DbSet<Apr> Aprs { get; set; } = null!;
        public virtual DbSet<AprSpecificParameter> AprSpecificParameters { get; set; } = null!;
        public virtual DbSet<Collimator> Collimators { get; set; } = null!;
        public virtual DbSet<Constitution> Constitutions { get; set; } = null!;
        public virtual DbSet<Contrast> Contrasts { get; set; } = null!;
        public virtual DbSet<DefaultApr> DefaultAprs { get; set; } = null!;
        public virtual DbSet<DetectorParameter> DetectorParameters { get; set; } = null!;
        public virtual DbSet<DetectorType> DetectorTypes { get; set; } = null!;
        public virtual DbSet<DetectorWorkstation> DetectorWorkstations { get; set; } = null!;
        public virtual DbSet<DisplayApr> DisplayAprs { get; set; } = null!;
        public virtual DbSet<DoseMultiplier> DoseMultipliers { get; set; } = null!;
        public virtual DbSet<EosType> EosTypes { get; set; } = null!;
        public virtual DbSet<Examination> Examinations { get; set; } = null!;
        public virtual DbSet<ExaminationParameter> ExaminationParameters { get; set; } = null!;
        public virtual DbSet<FieldCoefficient> FieldCoefficients { get; set; } = null!;
        public virtual DbSet<Generator> Generators { get; set; } = null!;
        public virtual DbSet<GeneratorWorkStation> GeneratorWorkStations { get; set; } = null!;
        public virtual DbSet<Laterality> Lateralities { get; set; } = null!;
        public virtual DbSet<LogicalWorkstation> LogicalWorkstations { get; set; } = null!;
        public virtual DbSet<Projection> Projections { get; set; } = null!;
        public virtual DbSet<Rack> Racks { get; set; } = null!;
        public virtual DbSet<RackPreset> RackPresets { get; set; } = null!;
        public virtual DbSet<RackType> RackTypes { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<Report30Type> Report30Types { get; set; } = null!;
        public virtual DbSet<Report3DozType> Report3DozTypes { get; set; } = null!;
        public virtual DbSet<ShootingParameter> ShootingParameters { get; set; } = null!;
        public virtual DbSet<SoftwareAprType> SoftwareAprTypes { get; set; } = null!;
        public virtual DbSet<SoftwareInnerType> SoftwareInnerTypes { get; set; } = null!;
        public virtual DbSet<SoftwareType> SoftwareTypes { get; set; } = null!;
        public virtual DbSet<TlsDirectory> TlsDirectories { get; set; } = null!;
        public virtual DbSet<TomoParameter> TomoParameters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=APR;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalParam>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ADDITIONALPARAM")
                    .IsClustered(false);

                entity.ToTable("AdditionalParam");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Apr)
                    .WithMany(p => p.AdditionalParams)
                    .HasForeignKey(d => d.AprId)
                    .HasConstraintName("FK_ADDITION_REFERENCE_APR");
            });

            modelBuilder.Entity<AgeGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_AGE")
                    .IsClustered(false);

                entity.ToTable("AgeGroup");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnatomicRegion>(entity =>
            {
                entity.ToTable("AnatomicRegion");

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

            modelBuilder.Entity<Apr>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_APR")
                    .IsClustered(false);

                entity.ToTable("Apr");

                entity.Property(e => e.AuxTex)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LogicalWorkstationId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.Age)
                    .WithMany(p => p.Aprs)
                    .HasForeignKey(d => d.AgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APR_REFERENCE_AGE");

                entity.HasOne(d => d.DetectorType)
                    .WithMany(p => p.Aprs)
                    .HasForeignKey(d => d.DetectorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APR_REFERENCE_DETECTOR");

                entity.HasOne(d => d.ExaminationParam)
                    .WithMany(p => p.Aprs)
                    .HasForeignKey(d => d.ExaminationParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APR_REFERENCE_EXAMITAI");

                entity.HasOne(d => d.LogicalWorkstation)
                    .WithMany(p => p.Aprs)
                    .HasForeignKey(d => d.LogicalWorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apr_LogicalWorkstationId");
            });

            modelBuilder.Entity<AprSpecificParameter>(entity =>
            {
                entity.HasOne(d => d.Apr)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.AprId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_Apr");

                entity.HasOne(d => d.Collimator)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.CollimatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_Collimator");

                entity.HasOne(d => d.DetectorParam)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.DetectorParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_DetectorParam");

                entity.HasOne(d => d.Generator)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.GeneratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_Generator");

                entity.HasOne(d => d.Rack)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.RackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_Rack");

                entity.HasOne(d => d.ShootingParam)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.ShootingParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_ShootingParam");

                entity.HasOne(d => d.ShotTypeTls)
                    .WithMany(p => p.AprSpecificParameterShotTypeTls)
                    .HasForeignKey(d => d.ShotTypeTlsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_ShotTypeTls");

                entity.HasOne(d => d.TlsDirectory)
                    .WithMany(p => p.AprSpecificParameterTlsDirectories)
                    .HasForeignKey(d => d.TlsDirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AprSpecificParameters_TlsDirectory");

                entity.HasOne(d => d.TomoParameter)
                    .WithMany(p => p.AprSpecificParameters)
                    .HasForeignKey(d => d.TomoParameterId)
                    .HasConstraintName("FK_AprSpecificParameters_TomoParameter");
            });

            modelBuilder.Entity<Collimator>(entity =>
            {
                entity.ToTable("Collimator");

                entity.Property(e => e.Shape)
                    .HasMaxLength(64)
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

            modelBuilder.Entity<Contrast>(entity =>
            {
                entity.ToTable("Contrast");

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

            modelBuilder.Entity<DefaultApr>(entity =>
            {
                entity.ToTable("DefaultApr");

                entity.Property(e => e.LogicalWorkstationId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Examination)
                    .WithMany(p => p.DefaultAprs)
                    .HasForeignKey(d => d.ExaminationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DefaultApr_Examination");

                entity.HasOne(d => d.LogicalWorkstation)
                    .WithMany(p => p.DefaultAprs)
                    .HasForeignKey(d => d.LogicalWorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DefaultApr_LogicalWorkstation");

                entity.HasOne(d => d.Projection)
                    .WithMany(p => p.DefaultAprs)
                    .HasForeignKey(d => d.ProjectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DefaultApr_Projection");
            });

            modelBuilder.Entity<DetectorParameter>(entity =>
            {
                entity.Property(e => e.Dsl).HasColumnName("DSL");

                entity.Property(e => e.Dsm).HasColumnName("DSM");
            });

            modelBuilder.Entity<DetectorType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_DETECTORTYPE")
                    .IsClustered(false);

                entity.ToTable("DetectorType");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetectorWorkstation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DetectorWorkstation");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.LogicalWorkstation)
                    .WithMany()
                    .HasForeignKey(d => d.LogicalWorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetectorWorkstation_LogicalWorkstation");
            });

            modelBuilder.Entity<DisplayApr>(entity =>
            {
                entity.HasIndex(e => new { e.AprId, e.RoiId }, "IX_DisplayAprs")
                    .IsUnique();

                entity.HasOne(d => d.Apr)
                    .WithMany(p => p.DisplayAprs)
                    .HasForeignKey(d => d.AprId)
                    .HasConstraintName("FK_DisplayAprs_APR");
            });

            modelBuilder.Entity<DoseMultiplier>(entity =>
            {
                entity.ToTable("DoseMultiplier");
            });

            modelBuilder.Entity<EosType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_EOSTYPES")
                    .IsClustered(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Examination>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_EXAMINATION")
                    .IsClustered(false);

                entity.ToTable("Examination");

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmdName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.AnatomicRegion)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.AnatomicRegionId)
                    .HasConstraintName("FK_Examination_AnatomicRegion");

                entity.HasOne(d => d.EosTypes)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.EosTypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Examination_EOSTypes");

                entity.HasOne(d => d.Report30Types)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.Report30TypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Examination_Report30Types");

                entity.HasOne(d => d.Report3DozTypes)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(d => d.Report3DozTypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Examination_Report3DOZTypes");
            });

            modelBuilder.Entity<ExaminationParameter>(entity =>
            {
                entity.ToTable("ExaminationParameter");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Constitution)
                    .WithMany(p => p.ExaminationParameters)
                    .HasForeignKey(d => d.ConstitutionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamitaionParameter_Constitution");

                entity.HasOne(d => d.Contrast)
                    .WithMany(p => p.ExaminationParameters)
                    .HasForeignKey(d => d.ContrastId)
                    .HasConstraintName("FK_EXAMITAI_REFERENCE_CONTRAST");

                entity.HasOne(d => d.Examination)
                    .WithMany(p => p.ExaminationParameters)
                    .HasForeignKey(d => d.ExaminationId)
                    .HasConstraintName("FK_EXAMITAI_REFERENCE_EXAMINAT");

                entity.HasOne(d => d.Laterality)
                    .WithMany(p => p.ExaminationParameters)
                    .HasForeignKey(d => d.LateralityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamitaionParameter_Laterality");

                entity.HasOne(d => d.Projection)
                    .WithMany(p => p.ExaminationParameters)
                    .HasForeignKey(d => d.ProjectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXAMITAI_REFERENCE_PROJECTI");
            });

            modelBuilder.Entity<FieldCoefficient>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FIELD")
                    .IsClustered(false);

                entity.ToTable("FieldCoefficient");

                //entity.Property(e => e.IsEnabled).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Generator>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_GENERATOR")
                    .IsClustered(false);

                entity.ToTable("Generator");

                entity.Property(e => e.Aeclevel)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AECLevel");

                entity.Property(e => e.Aecmode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AECMode");

                entity.Property(e => e.Aeczone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AECZone");

                entity.Property(e => e.BosFramerateId).HasColumnName("BosFramerateID");

                entity.Property(e => e.Grid)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneratorWorkStation>(entity =>
            {
                entity.ToTable("GeneratorWorkStation");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
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

            modelBuilder.Entity<LogicalWorkstation>(entity =>
            {
                entity.ToTable("LogicalWorkstation");

                //entity.Property(e => e.DosimeterId).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToolTip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(space((0)))");

                entity.Property(e => e.UniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.LogicalWorkstations)
                    .HasForeignKey(d => d.WorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetectorWorkstation_GeneratorWorkStation");
            });

            modelBuilder.Entity<Projection>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_PROJECTION")
                    .IsClustered(false);

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

            modelBuilder.Entity<Rack>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_RACK")
                    .IsClustered(false);

                entity.ToTable("Rack");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RackPreset>(entity =>
            {
                entity.Property(e => e.HstandHeightDiff).HasColumnName("HStandHeightDiff");

                entity.Property(e => e.HstandSid).HasColumnName("HStandSid");

                entity.Property(e => e.HstandTubeAngle).HasColumnName("HStandTubeAngle");

                entity.Property(e => e.Name)
                    .HasMaxLength(127)
                    .IsUnicode(false);

                entity.Property(e => e.VstandScolumnPos).HasColumnName("VStandSColumnPos");

                entity.Property(e => e.VstandSid).HasColumnName("VStandSid");

                entity.Property(e => e.VstandTubeAngle).HasColumnName("VStandTubeAngle");
            });

            modelBuilder.Entity<RackType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_RACKTYPE")
                    .IsClustered(false);

                entity.ToTable("RackType");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.HasOne(d => d.Examination)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ExaminationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExaminationRating_Examination");
            });

            modelBuilder.Entity<Report30Type>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_REPORT30TYPES")
                    .IsClustered(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Report3DozType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_REPORT3DOZTYPES")
                    .IsClustered(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShootingParameter>(entity =>
            {
                //entity.Property(e => e.Diaphragm).HasDefaultValueSql("((1))");

                //entity.Property(e => e.Fps).HasDefaultValueSql("((1))");

                //entity.Property(e => e.FpsMax).HasDefaultValueSql("((1))");

                //entity.Property(e => e.Series).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SoftwareAprType>(entity =>
            {
                entity.ToTable("SoftwareAprType");

                entity.HasIndex(e => new { e.AprId, e.SoftwareInnerTypeId }, "IX_SoftwareAprType")
                    .IsUnique();

                entity.HasOne(d => d.Apr)
                    .WithMany(p => p.SoftwareAprTypes)
                    .HasForeignKey(d => d.AprId)
                    .HasConstraintName("FK_SoftwareAprType_APR");

                entity.HasOne(d => d.SoftwareInnerType)
                    .WithMany(p => p.SoftwareAprTypes)
                    .HasForeignKey(d => d.SoftwareInnerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SoftwareAprType_SoftwareInnerType");
            });

            modelBuilder.Entity<SoftwareInnerType>(entity =>
            {
                entity.ToTable("SoftwareInnerType");

                entity.Property(e => e.Comment)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.SoftwareType)
                    .WithMany(p => p.SoftwareInnerTypes)
                    .HasForeignKey(d => d.SoftwareTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SoftwareInnerType_SoftwareType");
            });

            modelBuilder.Entity<SoftwareType>(entity =>
            {
                entity.ToTable("SoftwareType");

                entity.Property(e => e.Comment)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TlsDirectory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TLSDIRECTORY")
                    .IsClustered(false);

                entity.ToTable("TlsDirectory");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TomoParameter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("TomoParameter");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
