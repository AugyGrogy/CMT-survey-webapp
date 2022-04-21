using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StaffMembers;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StaffMembers
{
    public partial class ctmsurveyContext : DbContext
    {
/*        public ctmsurveyContext()
        {
        }*/

        public ctmsurveyContext(DbContextOptions<ctmsurveyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<InstructorSurveyAnswer> InstructorSurveyAnswer { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<ParentSurveyAnswer> ParentSurveyAnswer { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Staff> Staff_Connected_To_Database { get; set; }
        public virtual DbSet<Recipient> Recipient { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Sites> Sites { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.AnswerId);

                entity.ToTable("ANSWERS");

                entity.Property(e => e.AnswerId)
                    .HasColumnName("answerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnswerText)
                    .IsRequired()
                    .HasColumnName("answerText")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("questionID");

                entity.Property(e => e.QuestionType).HasColumnName("questionType");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("INSTRUCTOR");

                entity.Property(e => e.InstructorId)
                    .HasColumnName("instructorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.QuarterId).HasColumnName("quarterID");

                entity.Property(e => e.TimeFrameId).HasColumnName("timeFrameID");
            });

            modelBuilder.Entity<InstructorSurveyAnswer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INSTRUCTOR_SURVEY_ANSWER");

                entity.Property(e => e.AnswerId).HasColumnName("answerID");

                entity.Property(e => e.InstructorId).HasColumnName("instructorID");

                entity.Property(e => e.QuestionId).HasColumnName("questionID");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("PARENT");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.QuarterId).HasColumnName("quarterID");

                entity.Property(e => e.TimeframeId).HasColumnName("timeframeID");
            });

            modelBuilder.Entity<ParentSurveyAnswer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PARENT_SURVEY_ANSWER");

                entity.Property(e => e.AnswerId).HasColumnName("answerID");

                entity.Property(e => e.ParentId).HasColumnName("parentID");

                entity.Property(e => e.QuestionId).HasColumnName("questionID");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QUESTION_TYPE");

                entity.Property(e => e.QuestionDescription)
                    .IsRequired()
                    .HasColumnName("questionDescription")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType1).HasColumnName("questionType");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("QUESTIONS");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("questionID");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnName("questionText")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionType)
                    .HasColumnName("questionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerA)
                    .HasColumnName("AnswerA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerB)
                    .HasColumnName("AnswerB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerC)
                    .HasColumnName("AnswerC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerD)
                    .HasColumnName("AnswerD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerE)
                    .HasColumnName("AnswerE")
                    .HasMaxLength(255)
                    .IsUnicode(false);


                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effectiveDate")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expirationDate")
                    .HasColumnType("date");

                

                entity.Property(e => e.QuestionType).HasColumnName("questionType");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("STAFF");

                entity.Property(e => e.StaffId)
                    .HasColumnName("staffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StaffEmail)
                    .IsRequired()
                    .HasColumnName("staffEmail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StaffFname)
                    .IsRequired()
                    .HasColumnName("staffFName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StaffLname)
                    .IsRequired()
                    .HasColumnName("staffLName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StaffPassword)
                    .IsRequired()
                    .HasColumnName("staffPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffRole)
                    .IsRequired()
                    .HasColumnName("staffRole")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recipient>(entity =>
            {
                entity.HasKey(e => e.RecipientID);

                entity.ToTable("RECIPIENT");

                entity.Property(e => e.RecipientID)
                    .HasColumnName("RecipientID");

                entity.Property(e => e.RecipientType)
                    .IsRequired()
                    .HasColumnName("RecipientType")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ChildName)
                    .HasColumnName("ChildName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.sessionID)
                    .HasColumnName("sessionID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.siteID)
                    .HasColumnName("siteID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.sessionID);

                entity.ToTable("SESSIONS");

                entity.Property(e => e.sessionID)
                    .HasColumnName("sessionID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.sessionName)
                    .HasColumnName("sessionName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sites>(entity =>
            {
                entity.HasKey(e => e.siteID);

                entity.ToTable("SITES");

                entity.Property(e => e.siteID)
                    .HasColumnName("siteID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.siteName)
                    .HasColumnName("siteName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<StaffMembers.Sessions> Sessions_1 { get; set; }

        public DbSet<StaffMembers.Sites> Sites_1 { get; set; }
    }
}
