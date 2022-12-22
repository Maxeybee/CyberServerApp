using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberServerApp.Migrations
{
    public partial class addCustomUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CyberUserName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CyberUserName",
                table: "AspNetUsers");
        }
    }
}
