using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOMS.Persistence.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CustomerContext");

            migrationBuilder.EnsureSchema(
                name: "DefinitionContext");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Gender = table.Column<int>(type: "Int", nullable: false),
                    MartialStatus = table.Column<int>(type: "Int", nullable: false),
                    RegDateTime = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                schema: "DefinitionContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Gender = table.Column<int>(type: "Int", nullable: false),
                    MartialStatus = table.Column<int>(type: "Int", nullable: false),
                    RegDateTime = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                schema: "DefinitionContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Therapist",
                schema: "DefinitionContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Gender = table.Column<int>(type: "Int", nullable: false),
                    MartialStatus = table.Column<int>(type: "Int", nullable: false),
                    RegDateTime = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reception",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TherapistId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    ReceptionDateTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Price = table.Column<int>(type: "Int", nullable: false),
                    ExteraPrice = table.Column<int>(type: "Int", nullable: false),
                    Discount = table.Column<int>(type: "Int", nullable: false),
                    TotalPrice = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reception", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reception_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "CustomerContext",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reception_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reception_Therapist_TherapistId",
                        column: x => x.TherapistId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Therapist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sequencing",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TherapistId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SubmitDateTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TurnDateTime = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sequencing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sequencing_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "CustomerContext",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sequencing_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sequencing_Therapist_TherapistId",
                        column: x => x.TherapistId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Therapist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);

                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    ReceptionId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Cash = table.Column<int>(type: "Int", nullable: false),
                    Pose = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Reception_ReceptionId",
                        column: x => x.ReceptionId,
                        principalSchema: "CustomerContext",
                        principalTable: "Reception",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionDetails",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    ReceptionId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    ProcedureId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceptionDetails_Reception_ReceptionId",
                        column: x => x.ReceptionId,
                        principalSchema: "CustomerContext",
                        principalTable: "Reception",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptionDetails_Procedure_ProcedureId",
                        column: x => x.ProcedureId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Procedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedureList",
                schema: "CustomerContext",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SequencingId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    ProcedureId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedureList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcedureList_Sequencing_SequencingId",
                        column: x => x.SequencingId,
                        principalSchema: "CustomerContext",
                        principalTable: "Sequencing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcedureList_Procedure_ProcedureId",
                        column: x => x.ProcedureId,
                        principalSchema: "DefinitionContext",
                        principalTable: "Procedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");


            migrationBuilder.CreateIndex(
                name: "IX_Payment_ReceptionId",
                schema: "CustomerContext",
                table: "Payment",
                column: "ReceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedureList_SequencingId",
                schema: "CustomerContext",
                table: "ProcedureList",
                column: "SequencingId");
            migrationBuilder.CreateIndex(
                  name: "IX_ProcedureList_ProcedureId",
                  schema: "CustomerContext",
                  table: "ProcedureList",
                  column: "ProcedureId");//--this

            migrationBuilder.CreateIndex(
                name: "IX_Reception_CustomerId",
                schema: "CustomerContext",
                table: "Reception",
                column: "CustomerId");
            migrationBuilder.CreateIndex(
                name: "IX_Reception_DoctorId",
                schema: "CustomerContext",
                table: "Reception",
                column: "DoctorId"
                );//--this
            migrationBuilder.CreateIndex(
                name: "IX_Reception_TherapistId",
                schema: "CustomerContext",
                table: "Reception",
                column: "TherapistId"
                );//--this

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionDetails_ReceptionId",
                schema: "CustomerContext",
                table: "ReceptionDetails",
                column: "ReceptionId");
            migrationBuilder.CreateIndex(
                 name: "IX_ReceptionDetails_ProcedureId",
                 schema: "CustomerContext",
                 table: "ReceptionDetails",
                 column: "ProcedureId");//--this

            migrationBuilder.CreateIndex(
                name: "IX_Sequencing_CustomerId",
                schema: "CustomerContext",
                table: "Sequencing",
                column: "CustomerId");
            migrationBuilder.CreateIndex(
                name: "FK_Sequencing_DoctorId",
                schema: "CustomerContext",
                table: "Sequencing",
                column: "DoctorId");//--this
            migrationBuilder.CreateIndex(
                name: "FK_Sequencing_TherapistId",
                schema: "CustomerContext",
                table: "Sequencing",
                column: "TherapistId");//--this

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Doctor",
                schema: "DefinitionContext");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "CustomerContext");

            migrationBuilder.DropTable(
                name: "Procedure",
                schema: "DefinitionContext");

            migrationBuilder.DropTable(
                name: "ProcedureList",
                schema: "CustomerContext");

            migrationBuilder.DropTable(
                name: "ReceptionDetails",
                schema: "CustomerContext");

            migrationBuilder.DropTable(
                name: "Therapist",
                schema: "DefinitionContext");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sequencing",
                schema: "CustomerContext");

            migrationBuilder.DropTable(
                name: "Reception",
                schema: "CustomerContext");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "CustomerContext");
        }
    }
}
