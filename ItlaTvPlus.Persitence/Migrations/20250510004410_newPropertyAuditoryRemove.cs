using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItlaTvPlus.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class newPropertyAuditoryRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Remuve",
                table: "Series",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Remuve",
                table: "Productoras",
                type: "bit",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Remuve",
                table: "Generos",
                type: "bit",
                nullable: true,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remuve",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "Remuve",
                table: "Productoras");

            migrationBuilder.DropColumn(
                name: "Remuve",
                table: "Generos");
        }
    }
}
