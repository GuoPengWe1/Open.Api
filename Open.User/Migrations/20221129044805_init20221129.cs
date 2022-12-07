using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Open.User.Migrations
{
    /// <inheritdoc />
    public partial class init20221129 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpenDB_UserInfo",
                table: "OpenDB_UserInfo");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OpenDB_UserInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpenDB_UserInfo",
                table: "OpenDB_UserInfo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpenDB_UserInfo",
                table: "OpenDB_UserInfo");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "OpenDB_UserInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpenDB_UserInfo",
                table: "OpenDB_UserInfo",
                column: "UserName");
        }
    }
}
