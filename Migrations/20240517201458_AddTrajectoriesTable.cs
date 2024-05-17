using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddTrajectoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Trajectories",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Trajectories",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Trajectories",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trajectories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TaxiId",
                table: "Trajectories",
                newName: "taxi_id");

            migrationBuilder.RenameColumn(
                name: "Plate",
                table: "taxis",
                newName: "plate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "taxis",
                newName: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Trajectories_taxi_id",
                table: "Trajectories",
                column: "taxi_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trajectories_taxis_taxi_id",
                table: "Trajectories",
                column: "taxi_id",
                principalTable: "taxis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trajectories_taxis_taxi_id",
                table: "Trajectories");

            migrationBuilder.DropIndex(
                name: "IX_Trajectories_taxi_id",
                table: "Trajectories");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Trajectories",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Trajectories",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Trajectories",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Trajectories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "taxi_id",
                table: "Trajectories",
                newName: "TaxiId");

            migrationBuilder.RenameColumn(
                name: "plate",
                table: "taxis",
                newName: "Plate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "taxis",
                newName: "Id");
        }
    }
}
