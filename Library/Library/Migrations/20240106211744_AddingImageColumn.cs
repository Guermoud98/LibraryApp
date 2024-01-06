using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class AddingImageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnneePublication",
                table: "Livres");

            migrationBuilder.DropColumn(
                name: "Editeur",
                table: "Livres");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Livres",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Livres");

            migrationBuilder.AddColumn<int>(
                name: "AnneePublication",
                table: "Livres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Editeur",
                table: "Livres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
