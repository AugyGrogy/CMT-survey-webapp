using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class QuestionRepository : IQuestionRepository
    {
        private IQuestionDBContext _dbcontext;
        public QuestionRepository(IQuestionDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Create(Question question)
        {
            _dbcontext.Questions.Add(question);
            await _dbcontext.SaveChanges();
            return question.questionID;
        }

        public async Task<List<Question>> GetAll()
        {
            var question = await _dbcontext.Questions.ToListAsync<Question>();
            return question;
        }

        public async Task<Question> GetById(int id)
        {
            var question = await _dbcontext.Questions.Where(qid => qid.questionID == id).FirstOrDefaultAsync();
            return question;
        }

        public async Task<string> Update(int id, Question question)
        {
            var questionupt = await _dbcontext.Questions.Where(qid => qid.questionID == id).FirstOrDefaultAsync();
            if (questionupt == null) return "Question does not exist";

            questionupt.questionType = question.questionType;
            questionupt.questionText = question.questionText;

            await _dbcontext.SaveChanges();
            return "Question details successfully modified";
        }

        public async Task<string> Delete(int id)
        {
            var questiondel = _dbcontext.Questions.Where(qid => qid.questionID == id).FirstOrDefault();
            if (questiondel == null) return "Question does not exist";

            _dbcontext.Questions.Remove(questiondel);
            await _dbcontext.SaveChanges();
            return "Question successfully deleted";
        }
    }
}