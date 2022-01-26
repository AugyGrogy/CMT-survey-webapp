using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class QuestionDBContext : DbContext, IQuestionDBContext
    {
        public QuestionDBContext(DbContextOptions<QuestionDBContext> options)
            : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}