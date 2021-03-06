// <auto-generated />
using System;
using MOMS.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOMS.Persistence.Migrations
{
    [DbContext(typeof(MOMSDbContext))]
    [Migration("20210720200122_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("FatherName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FileNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Gender")
                        .HasColumnType("Int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("MartialStatus")
                        .HasColumnType("Int");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NationalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegDateTime")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Customer", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<int>("Cash")
                        .HasColumnType("Int");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("DateTime");

                    b.Property<int>("Pose")
                        .HasColumnType("Int");

                    b.Property<Guid>("ReceptionId")
                        .HasColumnType("UniqueIdentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReceptionId");

                    b.ToTable("Payment", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Reception", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<int>("Discount")
                        .HasColumnType("Int");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<int>("ExteraPrice")
                        .HasColumnType("Int");

                    b.Property<string>("PaymentNumber")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Price")
                        .HasColumnType("Int");

                    b.Property<DateTime>("ReceptionDateTime")
                        .HasColumnType("DateTime");

                    b.Property<Guid>("TherapistId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("Int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reception", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.ReceptionDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("ProcedureId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("ReceptionId")
                        .HasColumnType("UniqueIdentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReceptionId");

                    b.ToTable("ReceptionDetails", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Sequencings.ProcedureList", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("ProcedureId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("SequencingId")
                        .HasColumnType("UniqueIdentifier");

                    b.HasKey("Id");

                    b.HasIndex("SequencingId");

                    b.ToTable("ProcedureList", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Sequencings.Sequencing", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<DateTime>("SubmitDateTime")
                        .HasColumnType("DateTime");

                    b.Property<Guid>("TherapistId")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<DateTime>("TurnDateTime")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sequencing", "CustomerContext");
                });

            modelBuilder.Entity("MOMS.DefinitionContext.Domain.Doctors.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("FatherName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Gender")
                        .HasColumnType("Int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("MartialStatus")
                        .HasColumnType("Int");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NationalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegDateTime")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Doctor", "DefinitionContext");
                });

            modelBuilder.Entity("MOMS.DefinitionContext.Domain.Procedures.Procedure", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Price")
                        .HasColumnType("Int");

                    b.HasKey("Id");

                    b.ToTable("Procedure", "DefinitionContext");
                });

            modelBuilder.Entity("MOMS.DefinitionContext.Domain.Therapists.Therapist", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("UniqueIdentifier");

                    b.Property<string>("FatherName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Gender")
                        .HasColumnType("Int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("MartialStatus")
                        .HasColumnType("Int");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NationalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegDateTime")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("Therapist", "DefinitionContext");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Payment", b =>
                {
                    b.HasOne("MOMS.CustomerContext.Domain.Customers.Reception", null)
                        .WithMany("Payments")
                        .HasForeignKey("ReceptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Reception", b =>
                {
                    b.HasOne("MOMS.CustomerContext.Domain.Customers.Customer", null)
                        .WithMany("Receptions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.ReceptionDetails", b =>
                {
                    b.HasOne("MOMS.CustomerContext.Domain.Customers.Reception", null)
                        .WithMany("ReceptionDetails")
                        .HasForeignKey("ReceptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Sequencings.ProcedureList", b =>
                {
                    b.HasOne("MOMS.CustomerContext.Domain.Sequencings.Sequencing", null)
                        .WithMany("ProcedureLists")
                        .HasForeignKey("SequencingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Sequencings.Sequencing", b =>
                {
                    b.HasOne("MOMS.CustomerContext.Domain.Customers.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Customer", b =>
                {
                    b.Navigation("Receptions");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Customers.Reception", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("ReceptionDetails");
                });

            modelBuilder.Entity("MOMS.CustomerContext.Domain.Sequencings.Sequencing", b =>
                {
                    b.Navigation("ProcedureLists");
                });
#pragma warning restore 612, 618
        }
    }
}
