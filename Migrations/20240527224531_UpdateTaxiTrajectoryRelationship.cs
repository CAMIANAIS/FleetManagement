using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FleetManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTaxiTrajectoryRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trajectories_taxis_taxi_id",
                table: "Trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trajectories",
                table: "Trajectories");

            migrationBuilder.RenameTable(
                name: "Trajectories",
                newName: "trajectories");

            migrationBuilder.RenameColumn(
                name: "taxi_id",
                table: "trajectories",
                newName: "taxiid1");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "trajectories",
                newName: "taxiid");

            migrationBuilder.RenameIndex(
                name: "IX_Trajectories_taxi_id",
                table: "trajectories",
                newName: "IX_trajectories_taxiid1");

            migrationBuilder.AlterColumn<int>(
                name: "taxiid",
                table: "trajectories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "idtrajectories",
                table: "trajectories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_trajectories",
                table: "trajectories",
                column: "idtrajectories");

            migrationBuilder.CreateIndex(
                name: "IX_trajectories_taxiid",
                table: "trajectories",
                column: "taxiid");

            migrationBuilder.AddForeignKey(
                name: "FK_trajectories_taxis_taxiid",
                table: "trajectories",
                column: "taxiid",
                principalTable: "taxis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trajectories_taxis_taxiid1",
                table: "trajectories",
                column: "taxiid1",
                principalTable: "taxis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trajectories_taxis_taxiid",
                table: "trajectories");

            migrationBuilder.DropForeignKey(
                name: "FK_trajectories_taxis_taxiid1",
                table: "trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_trajectories",
                table: "trajectories");

            migrationBuilder.DropIndex(
                name: "IX_trajectories_taxiid",
                table: "trajectories");

            migrationBuilder.DropColumn(
                name: "idtrajectories",
                table: "trajectories");

            migrationBuilder.RenameTable(
                name: "trajectories",
                newName: "Trajectories");

            migrationBuilder.RenameColumn(
                name: "taxiid1",
                table: "Trajectories",
                newName: "taxi_id");

            migrationBuilder.RenameColumn(
                name: "taxiid",
                table: "Trajectories",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_trajectories_taxiid1",
                table: "Trajectories",
                newName: "IX_Trajectories_taxi_id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Trajectories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trajectories",
                table: "Trajectories",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trajectories_taxis_taxi_id",
                table: "Trajectories",
                column: "taxi_id",
                principalTable: "taxis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
