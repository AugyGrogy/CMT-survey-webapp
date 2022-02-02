using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffMembers.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANSWERS",
                columns: table => new
                {
                    answerID = table.Column<int>(nullable: false),
                    questionID = table.Column<int>(nullable: false),
                    answerText = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    questionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANSWERS", x => x.answerID);
                });

            migrationBuilder.CreateTable(
                name: "INSTRUCTOR",
                columns: table => new
                {
                    instructorID = table.Column<int>(nullable: false),
                    groupID = table.Column<int>(nullable: false),
                    quarterID = table.Column<int>(nullable: false),
                    timeFrameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTRUCTOR", x => x.instructorID);
                });

            migrationBuilder.CreateTable(
                name: "INSTRUCTOR_SURVEY_ANSWER",
                columns: table => new
                {
                    questionID = table.Column<int>(nullable: false),
                    instructorID = table.Column<int>(nullable: false),
                    answerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PARENT",
                columns: table => new
                {
                    parentID = table.Column<int>(nullable: false),
                    groupID = table.Column<int>(nullable: false),
                    quarterID = table.Column<int>(nullable: false),
                    timeframeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARENT", x => x.parentID);
                });

            migrationBuilder.CreateTable(
                name: "PARENT_SURVEY_ANSWER",
                columns: table => new
                {
                    questionID = table.Column<int>(nullable: false),
                    parentID = table.Column<int>(nullable: false),
                    answerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QUESTION_TYPE",
                columns: table => new
                {
                    questionType = table.Column<int>(nullable: false),
                    questionDescription = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONS",
                columns: table => new
                {
                    questionID = table.Column<int>(nullable: false),
                    questionType = table.Column<int>(nullable: false),
                    effectiveDate = table.Column<DateTime>(type: "date", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "date", nullable: true),
                    questionText = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONS", x => x.questionID);
                });

            migrationBuilder.CreateTable(
                name: "STAFF",
                columns: table => new
                {
                    staffID = table.Column<int>(nullable: false),
                    staffFName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    staffLName = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    staffEmail = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    staffRole = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    staffPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STAFF", x => x.staffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANSWERS");

            migrationBuilder.DropTable(
                name: "INSTRUCTOR");

            migrationBuilder.DropTable(
                name: "INSTRUCTOR_SURVEY_ANSWER");

            migrationBuilder.DropTable(
                name: "PARENT");

            migrationBuilder.DropTable(
                name: "PARENT_SURVEY_ANSWER");

            migrationBuilder.DropTable(
                name: "QUESTION_TYPE");

            migrationBuilder.DropTable(
                name: "QUESTIONS");

            migrationBuilder.DropTable(
                name: "STAFF");
        }
    }
}
