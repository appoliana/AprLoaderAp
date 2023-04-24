using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AprLoaderNew.EPO_Hardware
{
    public partial class EPO_hardwareContext : DbContext
    {
        public EPO_hardwareContext()
        {
        }

        public EPO_hardwareContext(DbContextOptions<EPO_hardwareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalDetectorTl> AdditionalDetectorTls { get; set; } = null!;
        public virtual DbSet<BosFramerate> BosFramerates { get; set; } = null!;
        public virtual DbSet<CommonPostProcessingParameter> CommonPostProcessingParameters { get; set; } = null!;
        public virtual DbSet<DosimeterParameter> DosimeterParameters { get; set; } = null!;
        public virtual DbSet<ExposureMode> ExposureModes { get; set; } = null!;
        public virtual DbSet<GeneratorParameter> GeneratorParameters { get; set; } = null!;
        public virtual DbSet<GeneratorRelay> GeneratorRelays { get; set; } = null!;
        public virtual DbSet<GeneratorRout> GeneratorRouts { get; set; } = null!;
        public virtual DbSet<GeneratorValue> GeneratorValues { get; set; } = null!;
        public virtual DbSet<GeneratorValueLimititation> GeneratorValueLimititations { get; set; } = null!;
        public virtual DbSet<GeneratorValueType> GeneratorValueTypes { get; set; } = null!;
        public virtual DbSet<GmmSetting> GmmSettings { get; set; } = null!;
        public virtual DbSet<GraphiaValueConversion> GraphiaValueConversions { get; set; } = null!;
        public virtual DbSet<HardwareCommonParameter> HardwareCommonParameters { get; set; } = null!;
        public virtual DbSet<HardwareDetector> HardwareDetectors { get; set; } = null!;
        public virtual DbSet<HardwareDicomParameter> HardwareDicomParameters { get; set; } = null!;
        public virtual DbSet<ImageSize> ImageSizes { get; set; } = null!;
        public virtual DbSet<PreprocessingTlsPath> PreprocessingTlsPaths { get; set; } = null!;
        public virtual DbSet<RackParameter> RackParameters { get; set; } = null!;
        public virtual DbSet<RasterParameter> RasterParameters { get; set; } = null!;
        public virtual DbSet<UpsParameter> UpsParameters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EPO_hardware;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalDetectorTl>(entity =>
            {
                entity.Property(e => e.CameraName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.HasOne(d => d.Detector)
                    .WithMany(p => p.AdditionalDetectorTls)
                    .HasForeignKey(d => d.DetectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdditionalDetectorTls_HardwareDetector");
            });

            modelBuilder.Entity<DosimeterParameter>(entity =>
            {
                entity.ToTable("DosimeterParameter");

                entity.Property(e => e.ConnectionString)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DosimeterType)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExposureMode>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneratorParameter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConnectionString)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GeneratorType)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Guid)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GeneratorRelay>(entity =>
            {
                entity.ToTable("GeneratorRelay");

                entity.HasIndex(e => e.Code, "IX_GeneratorRelay")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneratorRout>(entity =>
            {
                entity.ToTable("GeneratorRout");
            });

            modelBuilder.Entity<GeneratorValue>(entity =>
            {
                entity.HasIndex(e => e.Code, "IX_GeneratorValues")
                    .IsUnique();

                entity.Property(e => e.Comment)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.High)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Low)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Step)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Values)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.HasOne(d => d.ValueType)
                    .WithMany(p => p.GeneratorValues)
                    .HasForeignKey(d => d.ValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPO_Generator_Values_Generator_value_type");
            });

            modelBuilder.Entity<GeneratorValueLimititation>(entity =>
            {
                entity.Property(e => e.DependParamValue)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MainParamValue)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.DependParam)
                    .WithMany(p => p.GeneratorValueLimititationDependParams)
                    .HasForeignKey(d => d.DependParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Generator_value_limititations_EPO_Generator_DependValues");

                entity.HasOne(d => d.MainParam)
                    .WithMany(p => p.GeneratorValueLimititationMainParams)
                    .HasForeignKey(d => d.MainParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Generator_value_limititations_EPO_Generator_MainValues");
            });

            modelBuilder.Entity<GeneratorValueType>(entity =>
            {
                entity.ToTable("GeneratorValueType");

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GmmSetting>(entity =>
            {
                entity.Property(e => e.GmmCode)
                    .HasMaxLength(12)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GraphiaValueConversion>(entity =>
            {
                entity.ToTable("GraphiaValueConversion");
            });

            modelBuilder.Entity<HardwareCommonParameter>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HardwareDetector>(entity =>
            {
                entity.ToTable("HardwareDetector");

                entity.HasIndex(e => e.UniqueName, "IX_HardwareDetector")
                    .IsUnique();

                entity.Property(e => e.AprVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalibratedImageSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImagePixelSpacing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PreProcessingTlsKey)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TlsFilePath)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HardwareDicomParameter>(entity =>
            {
                entity.Property(e => e.DicomAttribute)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParameterComment)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterCommentLocalize)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreprocessingTlsPath>(entity =>
            {
                entity.ToTable("PreprocessingTlsPath");

                entity.Property(e => e.TlsPath)
                    .HasMaxLength(256)
                    .IsFixedLength();

                entity.HasOne(d => d.ExposureMode)
                    .WithMany(p => p.PreprocessingTlsPaths)
                    .HasForeignKey(d => d.ExposureModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreprocessingTlsPath_ExposureTypes");

                entity.HasOne(d => d.ImageSize)
                    .WithMany(p => p.PreprocessingTlsPaths)
                    .HasForeignKey(d => d.ImageSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreprocessingTlsPath_ImageSizes");
            });

            modelBuilder.Entity<RackParameter>(entity =>
            {
                entity.Property(e => e.ConnectionString)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RasterParameter>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsParameter>(entity =>
            {
                entity.ToTable("UpsParameter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConnectionString)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
