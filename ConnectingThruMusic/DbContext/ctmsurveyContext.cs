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
                    .IsRequired()
                    .HasColumnName("AnswerA")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerB)
                    .IsRequired()
                    .HasColumnName("AnswerB")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerC)
                    .IsRequired()
                    .HasColumnName("AnswerC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerD)
                    .IsRequired()
                    .HasColumnName("AnswerD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerE)
                    .IsRequired()
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

            OnModelCreatingPartial(modelBuilder);
            OnModelCreatingIdentity(modelBuilder);
        }

        private void OnModelCreatingIdentity(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
