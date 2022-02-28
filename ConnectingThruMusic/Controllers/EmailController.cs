using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Controllers
{
    public class EmailController : Controller
    {

        private readonly ctmsurveyContext _context;


        public EmailController(ctmsurveyContext context)
        {
            _context = context;
        }

        // GET: Email
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recipient.ToListAsync());
        }

        // GET: Email/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var email = await _context.Recipient
                .FirstOrDefaultAsync(m => m.RecipientID == id);
            if (email == null)
            {
                return NotFound();
            }

            return View(email);
        }

        // GET: Emails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Email/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecipientID,RecipientType,Name,Email,ChildName,sessionID,siteID")] Recipient recipient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipient);
        }

    }
}
