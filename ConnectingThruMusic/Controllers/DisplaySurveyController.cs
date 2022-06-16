using Microsoft.AspNetCore.Mvc;
using System;
using StaffMembers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace StaffMembers.Controllers
{
    public class DisplaySurveyController : Controller
    {
        private readonly ctmsurveyContext db = new ctmsurveyContext();

        public ActionResult DisplaySurvey()
        {
            var tables = new DisplaySurveyViewModel
            {
                Questions = db.Questions.ToList(),
                Survey = db.Survey.ToList(),
                SurveyQuestions = db.SurveyQuestions.ToList()
            };
            return View(tables);
        }
    }
}
