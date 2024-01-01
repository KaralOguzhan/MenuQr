using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrMenuAdonis.DataAccessLayer.Migrations
{
    public partial class mig_add_typeofmenu_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListType",
                table: "typeOfMenus");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "typeOfMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "typeOfMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "typeOfMenus");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "typeOfMenus");

            migrationBuilder.AddColumn<int>(
                name: "ListType",
                table: "typeOfMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
