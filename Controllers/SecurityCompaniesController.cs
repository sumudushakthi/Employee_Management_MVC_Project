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
    public class SecurityCompaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityCompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SecurityCompanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.SecurityCompanies.ToListAsync());
        }

        // GET: SecurityCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityCompany = await _context.SecurityCompanies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityCompany == null)
            {
                return NotFound();
            }

            return View(securityCompany);
        }

        // GET: SecurityCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SecurityCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,CompanyAddress,ContactPerson,ContactNumber,UserName,Password")] SecurityCompany securityCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(securityCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(securityCompany);
        }

        // GET: SecurityCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityCompany = await _context.SecurityCompanies.FindAsync(id);
            if (securityCompany == null)
            {
                return NotFound();
            }
            return View(securityCompany);
        }

        // POST: SecurityCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,CompanyAddress,ContactPerson,ContactNumber,UserName,Password")] SecurityCompany securityCompany)
        {
            if (id != securityCompany.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(securityCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityCompanyExists(securityCompany.Id))
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
            return View(securityCompany);
        }

        // GET: SecurityCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityCompany = await _context.SecurityCompanies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityCompany == null)
            {
                return NotFound();
            }

            return View(securityCompany);
        }

        // POST: SecurityCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var securityCompany = await _context.SecurityCompanies.FindAsync(id);
            if (securityCompany != null)
            {
                _context.SecurityCompanies.Remove(securityCompany);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityCompanyExists(int id)
        {
            return _context.SecurityCompanies.Any(e => e.Id == id);
        }
    }
}
