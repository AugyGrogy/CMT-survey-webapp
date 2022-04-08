using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers
{
    public class EmailController : Controller
    {

        private readonly ctmsurveyContext _context;


        public EmailController(ctmsurveyContext context)
        {
            _context = context;
        }

        // GET: Email
        public async Task<IActionResult> RecipientIndex()
        {
            return View(await _context.Recipient.ToListAsync());
        }

        // GET: Email/Details
        public async Task<IActionResult> RecipientDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipient = await _context.Recipient.FirstOrDefaultAsync(m => m.RecipientID == id);
            if (recipient == null)
            {
                return NotFound();
            }

            return View(recipient);
        }

        // GET: Emails/AddRecipient
        public IActionResult AddRecipient()
        {
            return View();
        }

        // POST: Email/AddRecipient
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRecipient([Bind("RecipientID,RecipientType,Name,Email,ChildName,sessionID,siteID")] Recipient recipient)
        {
            if (ModelState.IsValid) 
            {
                _context.Add(recipient);
                await _context.SaveChangesAsync();
                return RedirectToAction(("AddRecipient"));
            }
            return View(recipient);
        }

        // Get: Recipient/Delete
        public async Task<IActionResult> DeleteRecipient(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipient = await _context.Recipient.FirstOrDefaultAsync(m => m.RecipientID == id);

            if (recipient == null)
            {
                return NotFound();
            }

            return View(recipient);
        }

        // Post: Recipient/Delete
        [HttpPost, ActionName("DeleteRecipient")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipient = await _context.Recipient.FindAsync(id);
            _context.Recipient.Remove(recipient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RecipientIndex));

        }

        private bool RecipientExists(int id)
        {
            return _context.Recipient.Any(e => e.RecipientID == id);
        }

    }

}
