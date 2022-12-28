using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganizationManager.Models;

namespace OrganizationManager.Controllers
{
    public class CompanyOwnerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyOwnerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyOwner
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CompanyOwners.Include(c => c.Company);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CompanyOwner/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyOwner = await _context.CompanyOwners
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyOwner == null)
            {
                return NotFound();
            }

            return View(companyOwner);
        }

        // GET: CompanyOwner/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId");
            return View();
        }

        // POST: CompanyOwner/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,Id,Name,Surname,Mail,Phone,Password")] CompanyOwner companyOwner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyOwner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", companyOwner.CompanyId);
            return View(companyOwner);
        }

        // GET: CompanyOwner/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyOwner = await _context.CompanyOwners.FindAsync(id);
            if (companyOwner == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", companyOwner.CompanyId);
            return View(companyOwner);
        }

        // POST: CompanyOwner/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,Id,Name,Surname,Mail,Phone,Password")] CompanyOwner companyOwner)
        {
            if (id != companyOwner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyOwner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyOwnerExists(companyOwner.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId", companyOwner.CompanyId);
            return View(companyOwner);
        }

        // GET: CompanyOwner/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyOwner = await _context.CompanyOwners
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyOwner == null)
            {
                return NotFound();
            }

            return View(companyOwner);
        }

        // POST: CompanyOwner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companyOwner = await _context.CompanyOwners.FindAsync(id);
            _context.CompanyOwners.Remove(companyOwner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyOwnerExists(int id)
        {
            return _context.CompanyOwners.Any(e => e.Id == id);
        }
    }
}
