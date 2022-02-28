using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Controllers
{
    public class SitesController : Controller
    {
        // GET: Sites
        public ActionResult Index()
        {
            return View();
        }

        // GET: SitesController/Details
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SitesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SitesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SitesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SitesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SitesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SitesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
