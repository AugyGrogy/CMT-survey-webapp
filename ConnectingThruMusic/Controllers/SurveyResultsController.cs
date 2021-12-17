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

        [HttpPost]
        public FileResult Export()
        {
            List<SurveyResults> entities = Database.GetResults();
            List<object> results = entities.ToList<object>();

            results.Insert(0, new string[1] { " " });

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < results.Count; i++)
            {
                string[] result = (string[])results[i];
                for (int j = 0; j < result.Length; j++)
                {
                    sb.Append(result[j] + ',');
                }
                sb.Append("\r\n");

            }

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "Grid.csv");
        }
    }
}
}
