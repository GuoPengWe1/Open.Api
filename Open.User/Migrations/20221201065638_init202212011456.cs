using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Open.User.Migrations
{
    /// <inheritdoc />
    public partial class init202212011456 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeleteMark",
                table: "OpenDB_UserInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteMark",
                table: "OpenDB_UserInfo");
        }
    }
}
