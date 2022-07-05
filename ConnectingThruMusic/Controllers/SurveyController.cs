using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffMembers.Models;
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

        public async Task<IActionResult> SurveyIndex()
        {
            return View(await _context.Survey.ToListAsync());
        }

        public async Task<IActionResult> SurveyDetails(int? id)
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

        public async Task<IActionResult> CreateSurvey ()
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
            return RedirectToAction(("SurveyIndex"));
        }

        public async Task<IActionResult> SurveyResponse(int? id)
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

        public async Task<IActionResult> DisplaySurvey(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var survey = await _context.Survey.Where(c => c.SurveyID == id.Value).Include(i => i.SurveyQuestions).ThenInclude(i => i.Questions).SingleOrDefaultAsync();

            if (survey == null)
            {
                return NotFound();
            }
            return View(survey);
        }
    }
}
