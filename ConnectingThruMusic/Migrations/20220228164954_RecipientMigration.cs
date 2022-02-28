using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffMembers.Migrations
{
    public partial class RecipientMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "questionType",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AnswerA",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnswerB",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnswerC",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnswerD",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AnswerE",
                table: "QUESTIONS",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RECIPIENT",
                columns: table => new
                {
                    RecipientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientType = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    ChildName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    sessionID = table.Column<int>(unicode: false, maxLength: 255, nullable: false),
                    siteID = table.Column<int>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECIPIENT", x => x.RecipientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RECIPIENT");

            migrationBuilder.DropColumn(
                name: "AnswerA",
                table: "QUESTIONS");

            migrationBuilder.DropColumn(
                name: "AnswerB",
                table: "QUESTIONS");

            migrationBuilder.DropColumn(
                name: "AnswerC",
                table: "QUESTIONS");

            migrationBuilder.DropColumn(
                name: "AnswerD",
                table: "QUESTIONS");

            migrationBuilder.DropColumn(
                name: "AnswerE",
                table: "QUESTIONS");

            migrationBuilder.AlterColumn<int>(
                name: "questionType",
                table: "QUESTIONS",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
