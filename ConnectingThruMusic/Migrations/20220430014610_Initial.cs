using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffMembers.Migrations
{
    public partial class Initial : Migration
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
                name: "InstructorSurveyResponses",
                columns: table => new
                {
                    SurveyID = table.Column<int>(nullable: false),
                    SurveyName = table.Column<string>(nullable: true),
                    QuestionText = table.Column<string>(nullable: true),
                    QuestionResponse = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ResponseDate = table.Column<DateTime>(nullable: false)
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
                name: "ParentSurveyResponses",
                columns: table => new
                {
                    SurveyID = table.Column<int>(nullable: false),
                    SurveyName = table.Column<string>(nullable: true),
                    QuestionText = table.Column<string>(nullable: true),
                    QuestionResponse = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ResponseDate = table.Column<DateTime>(nullable: false)
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
                    questionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    questionText = table.Column<string>(type: "nvarchar(MAX)", unicode: false, nullable: false),
                    questionType = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AnswerA = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AnswerB = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AnswerC = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AnswerD = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AnswerE = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    effectiveDate = table.Column<DateTime>(type: "date", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONS", x => x.questionID);
                });

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
                    sessionID = table.Column<int>(unicode: false, maxLength: 255, nullable: true),
                    siteID = table.Column<int>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECIPIENT", x => x.RecipientID);
                });

            migrationBuilder.CreateTable(
                name: "SESSIONS",
                columns: table => new
                {
                    sessionID = table.Column<int>(unicode: false, maxLength: 255, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sessionName = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SESSIONS", x => x.sessionID);
                });

            migrationBuilder.CreateTable(
                name: "SITES",
                columns: table => new
                {
                    siteID = table.Column<int>(unicode: false, maxLength: 255, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    siteName = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SITES", x => x.siteID);
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

            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    SurveyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyName = table.Column<string>(nullable: true),
                    SurveyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.SurveyID);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestions",
                columns: table => new
                {
                    SurveyID = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestions", x => new { x.SurveyID, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_QUESTIONS_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QUESTIONS",
                        principalColumn: "questionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_Survey_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Survey",
                        principalColumn: "SurveyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_QuestionId",
                table: "SurveyQuestions",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANSWERS");

            migrationBuilder.DropTable(
                name: "INSTRUCTOR");

            migrationBuilder.DropTable(
                name: "InstructorSurveyResponses");

            migrationBuilder.DropTable(
                name: "PARENT");

            migrationBuilder.DropTable(
                name: "ParentSurveyResponses");

            migrationBuilder.DropTable(
                name: "QUESTION_TYPE");

            migrationBuilder.DropTable(
                name: "RECIPIENT");

            migrationBuilder.DropTable(
                name: "SESSIONS");

            migrationBuilder.DropTable(
                name: "SITES");

            migrationBuilder.DropTable(
                name: "STAFF");

            migrationBuilder.DropTable(
                name: "SurveyQuestions");

            migrationBuilder.DropTable(
                name: "QUESTIONS");

            migrationBuilder.DropTable(
                name: "Survey");
        }
    }
}
