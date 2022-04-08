using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ctmsurveyContext _context;

        public SurveyController(ctmsurveyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreateSurvey()
        {
            return View(await _context.Questions.ToListAsync());
        }
    }

   
}
