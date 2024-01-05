using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class AddingAdherentPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumTelephone",
                table: "Adherents",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Adherents",
                newName: "MotDePasse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Adherents",
                newName: "NumTelephone");

            migrationBuilder.RenameColumn(
                name: "MotDePasse",
                table: "Adherents",
                newName: "Adresse");
        }
    }
}
