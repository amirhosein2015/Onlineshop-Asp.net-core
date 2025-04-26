using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onlineshop.Migrations
{
    /// <inheritdoc />
    public partial class FixMenuId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<string>(
            //    name: "Id",
            //    table: "Menus",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nchar(10)",
            //    oldFixedLength: true,
            //    oldMaxLength: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Menus",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
