using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItlaTvPlus.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class newTableIntermediedBetweenSerieGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesGenders_Generos_GendersId",
                table: "SeriesGenders");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesGenders_Series_SeriesId",
                table: "SeriesGenders");

            migrationBuilder.RenameColumn(
                name: "SeriesId",
                table: "SeriesGenders",
                newName: "GenderId");

            migrationBuilder.RenameColumn(
                name: "GendersId",
                table: "SeriesGenders",
                newName: "SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_SeriesGenders_SeriesId",
                table: "SeriesGenders",
                newName: "IX_SeriesGenders_GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesGenders_Generos_GenderId",
                table: "SeriesGenders",
                column: "GenderId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesGenders_Series_SerieId",
                table: "SeriesGenders",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesGenders_Generos_GenderId",
                table: "SeriesGenders");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesGenders_Series_SerieId",
                table: "SeriesGenders");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "SeriesGenders",
                newName: "SeriesId");

            migrationBuilder.RenameColumn(
                name: "SerieId",
                table: "SeriesGenders",
                newName: "GendersId");

            migrationBuilder.RenameIndex(
                name: "IX_SeriesGenders_GenderId",
                table: "SeriesGenders",
                newName: "IX_SeriesGenders_SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesGenders_Generos_GendersId",
                table: "SeriesGenders",
                column: "GendersId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesGenders_Series_SeriesId",
                table: "SeriesGenders",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
