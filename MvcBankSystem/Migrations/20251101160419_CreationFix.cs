using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcBankSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_User_ManagerUserId",
                table: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_Branch_ManagerUserId",
                table: "Branch");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerUserId",
                table: "Branch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_ManagerUserId",
                table: "Branch",
                column: "ManagerUserId",
                unique: true,
                filter: "[ManagerUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_User_ManagerUserId",
                table: "Branch",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_User_ManagerUserId",
                table: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_Branch_ManagerUserId",
                table: "Branch");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerUserId",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branch_ManagerUserId",
                table: "Branch",
                column: "ManagerUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_User_ManagerUserId",
                table: "Branch",
                column: "ManagerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
