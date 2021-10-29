using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeniorProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeniorProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddEmails()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
