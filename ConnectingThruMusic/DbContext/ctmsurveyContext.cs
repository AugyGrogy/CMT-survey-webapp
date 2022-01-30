using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    .HasColumnName("questionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effectiveDate")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expirationDate")
                    .HasColumnType("date");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnName("questionText")
                    .HasMaxLength(255)
                    .IsUnicode(false);

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
