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
    public class SystemAdminsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SystemAdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SystemAdmins
        public async Task<IActionResult> Index()
        {
            return View(await _context.SystemAdmins.ToListAsync());
        }

        // GET: SystemAdmins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemAdmin = await _context.SystemAdmins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemAdmin == null)
            {
                return NotFound();
            }

            return View(systemAdmin);
        }

        // GET: SystemAdmins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SystemAdmins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,ContactNumber,Password")] SystemAdmin systemAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(systemAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(systemAdmin);
        }

        // GET: SystemAdmins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemAdmin = await _context.SystemAdmins.FindAsync(id);
            if (systemAdmin == null)
            {
                return NotFound();
            }
            return View(systemAdmin);
        }

        // POST: SystemAdmins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,ContactNumber,Password")] SystemAdmin systemAdmin)
        {
            if (id != systemAdmin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(systemAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemAdminExists(systemAdmin.Id))
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
            return View(systemAdmin);
        }

        // GET: SystemAdmins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemAdmin = await _context.SystemAdmins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systemAdmin == null)
            {
                return NotFound();
            }

            return View(systemAdmin);
        }

        // POST: SystemAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var systemAdmin = await _context.SystemAdmins.FindAsync(id);
            if (systemAdmin != null)
            {
                _context.SystemAdmins.Remove(systemAdmin);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SystemAdminExists(int id)
        {
            return _context.SystemAdmins.Any(e => e.Id == id);
        }
    }
}
