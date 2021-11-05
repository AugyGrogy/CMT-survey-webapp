using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffMembers.Models;



namespace StaffMembers.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult dropdown()
        {
            return View();
        }
    }
}
