using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffMembers.Models;


namespace StaffMembers.Controllers
{
    public class DisplaySurveyController : Controller
    {
        private readonly ctmsurveyContext _context;

        public DisplaySurveyController(ctmsurveyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> SurveyIndex()
        {
            return View(await _context.Survey.ToListAsync());
        }

        //gets infoirmation of survey from db
        public async Task<IActionResult> DisplaySurvey(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var survey = await _context.Survey.FirstOrDefaultAsync(m => m.SurveyID == id);
            if (survey == null)
            {
                return NotFound();
            }
            return View(survey);
        }
    }
}
