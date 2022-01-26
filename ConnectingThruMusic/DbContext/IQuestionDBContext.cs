using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public interface IQuestionDBContext
    {
        DbSet<Question> Questions { get; set; }

        Task<int> SaveChanges();
    }
}