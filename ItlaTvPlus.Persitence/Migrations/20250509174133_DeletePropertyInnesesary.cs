using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItlaTvPlus.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class DeletePropertyInnesesary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Series");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Series",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
