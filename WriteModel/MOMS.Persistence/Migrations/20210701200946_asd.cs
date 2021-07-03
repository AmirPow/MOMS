using Microsoft.EntityFrameworkCore.Migrations;

namespace MOMS.Persistence.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "receptionDateTime",
                table: "Reception",
                newName: "ReceptionDateTime");

            migrationBuilder.RenameColumn(
                name: "PeymentDateTime",
                table: "Payment",
                newName: "PaymentDateTime");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Reception",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Reception");

            migrationBuilder.RenameColumn(
                name: "ReceptionDateTime",
                table: "Reception",
                newName: "receptionDateTime");

            migrationBuilder.RenameColumn(
                name: "PaymentDateTime",
                table: "Payment",
                newName: "PeymentDateTime");
        }
    }
}
