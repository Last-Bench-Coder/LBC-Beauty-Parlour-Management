using Microsoft.EntityFrameworkCore.Migrations;

namespace LBC.Beauty.Parlour.Management.DataAccess.Migrations
{
    public partial class tablenamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Administrators_EmailId_Phone",
                table: "Administrators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators");

            migrationBuilder.RenameTable(
                name: "Administrators",
                newName: "tbl_admin");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_tbl_admin_EmailId_Phone",
                table: "tbl_admin",
                columns: new[] { "EmailId", "Phone" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_admin",
                table: "tbl_admin",
                column: "AdminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_tbl_admin_EmailId_Phone",
                table: "tbl_admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_admin",
                table: "tbl_admin");

            migrationBuilder.RenameTable(
                name: "tbl_admin",
                newName: "Administrators");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Administrators_EmailId_Phone",
                table: "Administrators",
                columns: new[] { "EmailId", "Phone" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators",
                column: "AdminId");
        }
    }
}
