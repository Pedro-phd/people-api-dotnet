using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rinha_backend.Migrations
{
    /// <inheritdoc />
    public partial class changeToUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_people_Nickname",
                table: "people",
                column: "Nickname",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_people_Nickname",
                table: "people");
        }
    }
}
