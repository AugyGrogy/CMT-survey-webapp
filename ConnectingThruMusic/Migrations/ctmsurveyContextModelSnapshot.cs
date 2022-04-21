﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StaffMembers;

namespace StaffMembers.Migrations
{
    [DbContext(typeof(ctmsurveyContext))]
    partial class ctmsurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StaffMembers.Answers", b =>
                {
                    b.Property<int>("AnswerId")
                        .HasColumnName("answerID")
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasColumnName("answerText")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("QuestionId")
                        .HasColumnName("questionID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnName("questionType")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.ToTable("ANSWERS");
                });

            modelBuilder.Entity("StaffMembers.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnName("instructorID")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnName("groupID")
                        .HasColumnType("int");

                    b.Property<int>("QuarterId")
                        .HasColumnName("quarterID")
                        .HasColumnType("int");

                    b.Property<int>("TimeFrameId")
                        .HasColumnName("timeFrameID")
                        .HasColumnType("int");

                    b.HasKey("InstructorId");

                    b.ToTable("INSTRUCTOR");
                });

            modelBuilder.Entity("StaffMembers.InstructorSurveyAnswer", b =>
                {
                    b.Property<int>("AnswerId")
                        .HasColumnName("answerID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnName("instructorID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnName("questionID")
                        .HasColumnType("int");

                    b.ToTable("INSTRUCTOR_SURVEY_ANSWER");
                });

            modelBuilder.Entity("StaffMembers.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .HasColumnName("parentID")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnName("groupID")
                        .HasColumnType("int");

                    b.Property<int>("QuarterId")
                        .HasColumnName("quarterID")
                        .HasColumnType("int");

                    b.Property<int>("TimeframeId")
                        .HasColumnName("timeframeID")
                        .HasColumnType("int");

                    b.HasKey("ParentId");

                    b.ToTable("PARENT");
                });

            modelBuilder.Entity("StaffMembers.ParentSurveyAnswer", b =>
                {
                    b.Property<int>("AnswerId")
                        .HasColumnName("answerID")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnName("parentID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnName("questionID")
                        .HasColumnType("int");

                    b.ToTable("PARENT_SURVEY_ANSWER");
                });

            modelBuilder.Entity("StaffMembers.QuestionType", b =>
                {
                    b.Property<string>("QuestionDescription")
                        .IsRequired()
                        .HasColumnName("questionDescription")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("QuestionType1")
                        .HasColumnName("questionType")
                        .HasColumnType("int");

                    b.ToTable("QUESTION_TYPE");
                });

            modelBuilder.Entity("StaffMembers.Questions", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("questionID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerA")
                        .IsRequired()
                        .HasColumnName("AnswerA")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("AnswerB")
                        .HasColumnName("AnswerB")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("AnswerC")
                        .HasColumnName("AnswerC")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("AnswerD")
                        .HasColumnName("AnswerD")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("AnswerE")
                        .HasColumnName("AnswerE")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("EffectiveDate")
                        .HasColumnName("effectiveDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnName("expirationDate")
                        .HasColumnType("date");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnName("questionText")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("QuestionType")
                        .IsRequired()
                        .HasColumnName("questionType")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("SurveyID")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("SurveyID");

                    b.ToTable("QUESTIONS");
                });

            modelBuilder.Entity("StaffMembers.Recipient", b =>
                {
                    b.Property<int>("RecipientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecipientID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChildName")
                        .HasColumnName("ChildName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("RecipientType")
                        .IsRequired()
                        .HasColumnName("RecipientType")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("sessionID")
                        .HasColumnName("sessionID")
                        .HasColumnType("int")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("siteID")
                        .HasColumnName("siteID")
                        .HasColumnType("int")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("RecipientID");

                    b.ToTable("RECIPIENT");
                });

            modelBuilder.Entity("StaffMembers.Sessions", b =>
                {
                    b.Property<int>("sessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sessionID")
                        .HasColumnType("int")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sessionName")
                        .HasColumnName("sessionName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("sessionID");

                    b.ToTable("SESSIONS");
                });

            modelBuilder.Entity("StaffMembers.Sites", b =>
                {
                    b.Property<int>("siteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("siteID")
                        .HasColumnType("int")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("siteName")
                        .HasColumnName("siteName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("siteID");

                    b.ToTable("SITES");
                });

            modelBuilder.Entity("StaffMembers.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnName("staffID")
                        .HasColumnType("int");

                    b.Property<string>("StaffEmail")
                        .IsRequired()
                        .HasColumnName("staffEmail")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("StaffFname")
                        .IsRequired()
                        .HasColumnName("staffFName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("StaffLname")
                        .IsRequired()
                        .HasColumnName("staffLName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("StaffPassword")
                        .IsRequired()
                        .HasColumnName("staffPassword")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("StaffRole")
                        .IsRequired()
                        .HasColumnName("staffRole")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("StaffId");

                    b.ToTable("STAFF");
                });

            modelBuilder.Entity("StaffMembers.Survey", b =>
                {
                    b.Property<int>("SurveyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SurveyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurveyID");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("StaffMembers.Questions", b =>
                {
                    b.HasOne("StaffMembers.Survey", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyID");
                });
#pragma warning restore 612, 618
        }
    }
}
