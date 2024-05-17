using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaxiSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Taxi",
                table: "Taxi");

            migrationBuilder.RenameTable(
                name: "Taxi",
                newName: "taxis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_taxis",
                table: "taxis",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_taxis",
                table: "taxis");

            migrationBuilder.RenameTable(
                name: "taxis",
                newName: "Taxi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taxi",
                table: "Taxi",
                column: "Id");
        }
    }
}
