using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MOMS.Persistence.Migrations
{
    public partial class AddedPaymentNumberForReception : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<string>(
                name: "PaymentNumber",
                schema: "CustomerContext",
                table: "Reception",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentNumber",
                schema: "CustomerContext",
                table: "Reception");

          
        }
    }
}
