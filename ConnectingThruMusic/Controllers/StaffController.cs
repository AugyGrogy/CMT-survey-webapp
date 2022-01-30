using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffMembers.Models;


namespace StaffMembers.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult List()
        {
            List<StaffMembers.Models.Staff> staffs = Database.GetStaff();
            return View(staffs);

        }
    }
}

