using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class MOMS_DeveloperContext : DbContext
    {
        public MOMS_DeveloperContext()
        {
        }

        public MOMS_DeveloperContext(DbContextOptions<MOMS_DeveloperContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<ProcedureList> ProcedureLists { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual DbSet<Sequencing> Sequencings { get; set; }
        public virtual DbSet<Therapist> Therapists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =.,1433;Data Source=.;Database = MOMS_Developer;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "CustomerContext");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FatherName).HasMaxLength(250);

                entity.Property(e => e.FileNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MobileNumber).HasMaxLength(11);

                entity.Property(e => e.NationalCode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.RegDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor", "DefinitionContext");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FatherName).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MobileNumber).HasMaxLength(11);

                entity.Property(e => e.NationalCode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.RegDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment", "CustomerContext");

                entity.HasIndex(e => e.ReceptionId, "IX_Payment_ReceptionId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ReceptionId);
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.ToTable("Procedure", "DefinitionContext");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ProcedureList>(entity =>
            {
                entity.ToTable("ProcedureList", "CustomerContext");

                entity.HasIndex(e => e.ProcedureId, "IX_ProcedureList_ProcedureId");

                entity.HasIndex(e => e.SequencingId, "IX_ProcedureList_SequencingId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureLists)
                    .HasForeignKey(d => d.ProcedureId);

                entity.HasOne(d => d.Sequencing)
                    .WithMany(p => p.ProcedureLists)
                    .HasForeignKey(d => d.SequencingId);
            });

            modelBuilder.Entity<Reception>(entity =>
            {
                entity.ToTable("Reception", "CustomerContext");

                entity.HasIndex(e => e.CustomerId, "IX_Reception_CustomerId");

                entity.HasIndex(e => e.DoctorId, "IX_Reception_DoctorId");

                entity.HasIndex(e => e.TherapistId, "IX_Reception_TherapistId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ReceptionDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.Therapist)
                    .WithMany(p => p.Receptions)
                    .HasForeignKey(d => d.TherapistId);
            });

            modelBuilder.Entity<ReceptionDetail>(entity =>
            {
                entity.ToTable("ReceptionDetails", "CustomerContext");

                entity.HasIndex(e => e.ProcedureId, "IX_ReceptionDetails_ProcedureId");

                entity.HasIndex(e => e.ReceptionId, "IX_ReceptionDetails_ReceptionId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ReceptionDetails)
                    .HasForeignKey(d => d.ProcedureId);

                entity.HasOne(d => d.Reception)
                    .WithMany(p => p.ReceptionDetails)
                    .HasForeignKey(d => d.ReceptionId);
            });

            modelBuilder.Entity<Sequencing>(entity =>
            {
                entity.ToTable("Sequencing", "CustomerContext");

                entity.HasIndex(e => e.DoctorId, "FK_Sequencing_DoctorId");

                entity.HasIndex(e => e.TherapistId, "FK_Sequencing_TherapistId");

                entity.HasIndex(e => e.CustomerId, "IX_Sequencing_CustomerId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SubmitDateTime).HasColumnType("datetime");

                entity.Property(e => e.TurnDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sequencings)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Sequencings)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.Therapist)
                    .WithMany(p => p.Sequencings)
                    .HasForeignKey(d => d.TherapistId);
            });

            modelBuilder.Entity<Therapist>(entity =>
            {
                entity.ToTable("Therapist", "DefinitionContext");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FatherName).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MobileNumber).HasMaxLength(11);

                entity.Property(e => e.NationalCode).HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.RegDateTime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
