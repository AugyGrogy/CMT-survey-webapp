using Microsoft.AspNetCore.Mvc;

namespace StaffMembers.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult AddRecipient()
        {
            return View();
        }

        public IActionResult SurveyMgmt()
        {
            return View();
        }

        public IActionResult AddQuestion()
        {
            return View();
        }

        public IActionResult ConfigureQuestion()
        {
            return View();
        }

        public IActionResult EditQuestion()
        {
            return View();
        }
        public IActionResult SurveyAnalytics()
        {
            return View();
        }
        public IActionResult AnalyticsResult()
        {
            return View();
        }

    }
}
