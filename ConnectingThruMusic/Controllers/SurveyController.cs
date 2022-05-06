using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffMembers.Models;
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

        public async Task<IActionResult> Index ()
        {
            return View(new CreateSurveyViewModel()
            {
                Questions = await _context.Questions.ToListAsync()
            }) ;
        }

        public async Task<IActionResult> Create(CreateSurveyViewModel model)
        {
               _context.Add(model.ToEntity());
               await _context.SaveChangesAsync();
               return RedirectToAction(("CreateSurvey"));
        }
    }

   
}
