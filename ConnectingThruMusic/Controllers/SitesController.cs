using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMembers.Controllers
{
    public class SitesController : Controller
    {
        private readonly ctmsurveyContext _context;

        public SitesController(ctmsurveyContext context)
        {
            _context = context;
        }
        // Get: Sites
        public async Task<IActionResult> SitesIndex()
        {
            return View(await _context.Sites.ToListAsync());
        }

        //Get: Sites/SitesDetails
        public async Task<IActionResult> SitesDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var site = await _context.Sites.FirstOrDefaultAsync(m => m.siteID == id);
            if (site == null)
            {
                return NotFound();
            }
            return View(site);
        }

        // Get: Site/AddSite
        public IActionResult AddSite()
        {
            return View();
        }

        // Post: Site/AddSite
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSite([Bind("siteID, siteName")] Sites sites)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sites);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SitesIndex));
            }
            return View(sites);
        }

        // Get: Site/Edit
        public async Task<IActionResult> EditSite(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sites = await _context.Sites.FindAsync(id);

            if (sites == null)
            {
                return NotFound();
            }

            return View(sites);
        }

        // Post: EditSites/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSite(int id, [Bind("siteID, siteName")] Sites sites)
        {
            if (id != sites.siteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sites);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteExists(sites.siteID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(SitesIndex));
            }
            return View(sites);
        }

        // Get: Sites/Delete
        public async Task<IActionResult> DeleteSite(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sites = await _context.Sites.FirstOrDefaultAsync(m => m.siteID == id);

            if (sites == null)
            {
                return NotFound();
            }

            return View(sites);
        }

        // Post: Sites/Delete
        [HttpPost, ActionName("DeleteSite")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var site = await _context.Sites.FindAsync(id);
            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SitesIndex));

        }

        private bool SiteExists(int id)
        {
            return _context.Sites.Any(e => e.siteID == id);
        }
    }
}
