using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffMembers.Models;

namespace StaffMembers.Controllers
{
    public class SurveyResultsController : Controller
    {
        public IActionResult SurveyResults()
        {
            List<SurveyResults> results = Database.GetResults();
            return View(results);
        }


    }
}

