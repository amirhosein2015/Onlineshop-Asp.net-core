using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onlineshop.Migrations
{
    /// <inheritdoc />
    public partial class Init_BannerItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "BannerItems",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "BannerItems",
                newName: "Position");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "BannerItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "BannerItems");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "BannerItems",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "BannerItems",
                newName: "ImagePath");
        }
    }
}
