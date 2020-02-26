using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatRPCI.Data.Migrations
{
    public partial class chsv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chs_AspNetUsers_MutedUserId",
                table: "Chs");

            migrationBuilder.DropIndex(
                name: "IX_Chs_MutedUserId",
                table: "Chs");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Chs");

            migrationBuilder.AlterColumn<string>(
                name: "MutedUserId",
                table: "Chs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Chs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chs_UserId",
                table: "Chs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chs_AspNetUsers_UserId",
                table: "Chs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chs_AspNetUsers_UserId",
                table: "Chs");

            migrationBuilder.DropIndex(
                name: "IX_Chs_UserId",
                table: "Chs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Chs");

            migrationBuilder.AlterColumn<string>(
                name: "MutedUserId",
                table: "Chs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Chs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chs_MutedUserId",
                table: "Chs",
                column: "MutedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chs_AspNetUsers_MutedUserId",
                table: "Chs",
                column: "MutedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
