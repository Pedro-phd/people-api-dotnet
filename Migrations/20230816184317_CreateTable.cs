using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rinha_backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples");

            migrationBuilder.RenameTable(
                name: "Peoples",
                newName: "people");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                table: "people",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                table: "people");

            migrationBuilder.RenameTable(
                name: "people",
                newName: "Peoples");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples",
                column: "Id");
        }
    }
}
