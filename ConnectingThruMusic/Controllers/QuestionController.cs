using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace StaffMembers
{
    public class QuestionController : Controller
    {
        private readonly ctmsurveyContext _context;

        public QuestionController(ctmsurveyContext context)
        {
            _context = context;
        }
        
        // Get: Questions
        public async Task<IActionResult> QuestionIndex()
        {
            return View(await _context.Questions.ToListAsync());
        }

        //Get: Questions/QuestionDetails
        public async Task<IActionResult> QuestionDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FirstOrDefaultAsync(m => m.QuestionId == id);
            if(question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        // Get: Questions/AddQuestion
        public IActionResult AddQuestion()
        {
            return View();
        }

        // Post: Questions/AddQuestion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddQuestion([Bind("QuestionId, QuestionText, QuestionType, AnswerA, AnswerB, AnswerC, AnswerD, AnswerE, EffectiveDate, ExpirationDate")] Questions question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(QuestionIndex));
            }
            return View(question);
        }

        // Get: Question/Edit
        public async Task<IActionResult> EditQuestion(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var question = await _context.Questions.FindAsync(id);

            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // Post: EditQuestions/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion(int id, [Bind("QuestionId, QuestionText, QuestionType, AnswerA, AnswerB, AnswerC, AnswerD, AnswerE, EffectiveDate, ExpirationDate")] Questions question)
        {
            if (id != question.QuestionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.QuestionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(QuestionIndex));
            }
            return View(question);
        }

        // Get: Questions/Delete
        public async Task<IActionResult> DeleteQuestion (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FirstOrDefaultAsync(m => m.QuestionId == id);
            
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        // Post: Quesitons/Delete
        [HttpPost, ActionName("DeleteQuestion")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(QuestionIndex));

        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }
    }
}