using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StaffMembers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestionRepository _questionrepository;

        public QuestionController(IQuestionRepository questionrepository)
        {
            _questionrepository = questionrepository;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> create([FromBody] Question question)
        {
            int qid = await _questionrepository.Create(question);
            return Ok(qid);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var questions = await _questionrepository.GetAll();
            return Ok(questions);
        }

        [HttpGet]
        [Route("GetBYID/{id}")]
        public async Task<ActionResult> GetByID(int id)
        {
            var question = await _questionrepository.GetById(id);
            return Ok(question);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id, Question question)
        {
            string resp = await _questionrepository.Update(id, question);
            return Ok(resp);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var resp = await _questionrepository.Delete(id);
            return Ok(resp);
        }
    }
}