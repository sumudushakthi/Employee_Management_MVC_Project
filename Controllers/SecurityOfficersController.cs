using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Data;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class SecurityOfficersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityOfficersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SecurityOfficers
        public async Task<IActionResult> Index()
        {
            return View(await _context.SecurityOfficers.ToListAsync());
        }

        // GET: SecurityOfficers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityOfficers = await _context.SecurityOfficers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityOfficers == null)
            {
                return NotFound();
            }

            return View(securityOfficers);
        }

        // GET: SecurityOfficers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SecurityOfficers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,location,CompanyName,tCount,pCount,SId,EmployeeName,available")] SecurityOfficers securityOfficers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(securityOfficers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(securityOfficers);
        }

        // GET: SecurityOfficers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityOfficers = await _context.SecurityOfficers.FindAsync(id);
            if (securityOfficers == null)
            {
                return NotFound();
            }
            return View(securityOfficers);
        }

        // POST: SecurityOfficers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,location,CompanyName,tCount,pCount,SId,EmployeeName,available")] SecurityOfficers securityOfficers)
        {
            if (id != securityOfficers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(securityOfficers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityOfficersExists(securityOfficers.Id))
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
            return View(securityOfficers);
        }

        // GET: SecurityOfficers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityOfficers = await _context.SecurityOfficers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityOfficers == null)
            {
                return NotFound();
            }

            return View(securityOfficers);
        }

        // POST: SecurityOfficers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var securityOfficers = await _context.SecurityOfficers.FindAsync(id);
            if (securityOfficers != null)
            {
                _context.SecurityOfficers.Remove(securityOfficers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityOfficersExists(int id)
        {
            return _context.SecurityOfficers.Any(e => e.Id == id);
        }
    }
}
