using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Controllers
{


    public class SessionsController : Controller
    {

        private readonly ctmsurveyContext _context;

        public SessionsController(ctmsurveyContext context)
        {
            _context = context;
        }
        // Get: Sessions
        public async Task<IActionResult> SessionsIndex()
        {
            return View(await _context.Sessions.ToListAsync());
        }

        //Get: Sessions/SessionsDetails
        public async Task<IActionResult> SessionsDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Sessions.FirstOrDefaultAsync(m => m.sessionID == id);
            if (session == null)
            {
                return NotFound();
            }
            return View(session);
        }

        // Get: Sessions/AddSession
        public IActionResult AddSession()
        {
            return View();
        }

        // Post: Questions/AddQuestion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSession([Bind("sessionID, sessionName")] Sessions sessions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sessions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SessionsIndex));
            }
            return View(sessions);
        }

        // Get: Question/Edit
        public async Task<IActionResult> EditSession(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sessions = await _context.Sessions.FindAsync(id);

            if (sessions == null)
            {
                return NotFound();
            }

            return View(sessions);
        }

        // Post: EditQuestions/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion(int id, [Bind("sessionID, sessionName")] Sessions sessions)
        {
            if (id != sessions.sessionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionExists(sessions.sessionID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(SessionsIndex));
            }
            return View(sessions);
        }

        // Get: Questions/Delete
        public async Task<IActionResult> DeleteSession(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessions = await _context.Sessions.FirstOrDefaultAsync(m => m.sessionID == id);

            if (sessions == null)
            {
                return NotFound();
            }

            return View(sessions);
        }

        // Post: Quesitons/Delete
        [HttpPost, ActionName("DeleteSession")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var session = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(session);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SessionsIndex));

        }

        private bool SessionExists(int id)
        {
            return _context.Sessions.Any(e => e.sessionID == id);
        }
    }
}
