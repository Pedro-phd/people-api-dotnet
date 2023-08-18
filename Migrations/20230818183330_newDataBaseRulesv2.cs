using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rinha_backend.Migrations
{
    /// <inheritdoc />
    public partial class newDataBaseRulesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_peoples",
                table: "peoples");

            migrationBuilder.RenameTable(
                name: "peoples",
                newName: "people");

            migrationBuilder.RenameColumn(
                name: "stack",
                table: "people",
                newName: "Stack");

            migrationBuilder.RenameColumn(
                name: "nickname",
                table: "people",
                newName: "Nickname");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "people",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "birth",
                table: "people",
                newName: "Birth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "people",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_peoples_nickname",
                table: "people",
                newName: "IX_people_Nickname");

            migrationBuilder.AlterColumn<string>(
                name: "Search",
                table: "people",
                type: "text",
                nullable: false,
                computedColumnSql: "[name] + ' ' + [nickname]",
                oldClrType: typeof(string),
                oldType: "text",
                oldComputedColumnSql: "[Name] + ' ' + [Nickname]");

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
                newName: "peoples");

            migrationBuilder.RenameColumn(
                name: "Stack",
                table: "peoples",
                newName: "stack");

            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "peoples",
                newName: "nickname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "peoples",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Birth",
                table: "peoples",
                newName: "birth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "peoples",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_people_Nickname",
                table: "peoples",
                newName: "IX_peoples_nickname");

            migrationBuilder.AlterColumn<string>(
                name: "Search",
                table: "peoples",
                type: "text",
                nullable: false,
                computedColumnSql: "[Name] + ' ' + [Nickname]",
                oldClrType: typeof(string),
                oldType: "text",
                oldComputedColumnSql: "[name] + ' ' + [nickname]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_peoples",
                table: "peoples",
                column: "id");
        }
    }
}
