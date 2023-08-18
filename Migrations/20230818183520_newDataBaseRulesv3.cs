using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rinha_backend.Migrations
{
    /// <inheritdoc />
    public partial class newDataBaseRulesv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_people",
                table: "people");

            migrationBuilder.RenameTable(
                name: "people",
                newName: "peoples");

            migrationBuilder.RenameIndex(
                name: "IX_people_Nickname",
                table: "peoples",
                newName: "IX_peoples_Nickname");

            migrationBuilder.AddPrimaryKey(
                name: "PK_peoples",
                table: "peoples",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_peoples",
                table: "peoples");

            migrationBuilder.RenameTable(
                name: "peoples",
                newName: "people");

            migrationBuilder.RenameIndex(
                name: "IX_peoples_Nickname",
                table: "people",
                newName: "IX_people_Nickname");

            migrationBuilder.AddPrimaryKey(
                name: "PK_people",
                table: "people",
                column: "Id");
        }
    }
}
