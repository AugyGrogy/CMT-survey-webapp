using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public interface IQuestionRepository
    {
        Task<int> Create(Question question);
        Task<List<Question>> GetAll();
        Task<Question> GetById(int id);
        Task<string> Update(int id, Question quesiton);
        Task<string> Delete(int id);
    }
}