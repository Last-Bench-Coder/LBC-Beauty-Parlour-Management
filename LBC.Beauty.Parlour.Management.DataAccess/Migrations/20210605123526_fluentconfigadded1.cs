using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LBC.Beauty.Parlour.Management.DataAccess.Migrations
{
    public partial class fluentconfigadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_security_question",
                columns: table => new
                {
                    SecQuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecQuestion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_security_question", x => x.SecQuestId);
                    table.UniqueConstraint("AK_tbl_security_question_SecQuestion", x => x.SecQuestion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_security_question");
        }
    }
}
