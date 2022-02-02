using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace StaffMembers
{
    public class AnswerController : Controller
    {
        private readonly ctmsurveyContext _context;

        public AnswerController(ctmsurveyContext context)
        {
            _context = context;
        }

        // Get: Answers
        public async Task<IActionResult> AnswerIndex()
        {
            return View(await _context.Answers.ToListAsync());
        }

        //Get: Answer/AnswerDetails
        public async Task<IActionResult> AnswerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers.FirstOrDefaultAsync(m => m.QuestionId == id);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        // Get: Answers/AddAnswer
        public IActionResult AddAnswer()
        {
            return View();
        }

        // Post: Answers/AddAnswer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAnswer([Bind("AnswerId, QuestionId, AnswerText, QuestionType")] Answers answer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AnswerIndex));
            }
            return View(answer);
        }

        // Get: Answers/Edit
        public async Task<IActionResult> EditAnswer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var answer = await _context.Answers.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        // Post: EditAnswers/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnswers(int id, [Bind("AnswerId, QuestionId, AnswerText, QuestionType")] Answers answer)
        {
            if (id != answer.QuestionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerExists(answer.QuestionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AnswerIndex));
            }
            return View(answer);
        }

        // Get: Answers/Delete
        public async Task<IActionResult> DeleteAnswer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answers.FirstOrDefaultAsync(m => m.QuestionId == id);

            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // Post: Answers/Delete
        [HttpPost, ActionName("DeleteAnswer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answer = await _context.Answers.FirstOrDefaultAsync(m => m.QuestionId == id);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AnswerIndex));
        }

        private bool AnswerExists(int id)
        {
            return _context.Answers.Any(e => e.QuestionId == id);
        }

    }
}
