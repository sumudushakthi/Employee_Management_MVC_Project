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
    public class UserPrivilegesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserPrivilegesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserPrivileges
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserPrivileges.ToListAsync());
        }

        // GET: UserPrivileges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPrivilege = await _context.UserPrivileges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPrivilege == null)
            {
                return NotFound();
            }

            return View(userPrivilege);
        }

        // GET: UserPrivileges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserPrivileges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Level")] UserPrivilege userPrivilege)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userPrivilege);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userPrivilege);
        }

        // GET: UserPrivileges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPrivilege = await _context.UserPrivileges.FindAsync(id);
            if (userPrivilege == null)
            {
                return NotFound();
            }
            return View(userPrivilege);
        }

        // POST: UserPrivileges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Level")] UserPrivilege userPrivilege)
        {
            if (id != userPrivilege.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPrivilege);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPrivilegeExists(userPrivilege.Id))
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
            return View(userPrivilege);
        }

        // GET: UserPrivileges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPrivilege = await _context.UserPrivileges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPrivilege == null)
            {
                return NotFound();
            }

            return View(userPrivilege);
        }

        // POST: UserPrivileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userPrivilege = await _context.UserPrivileges.FindAsync(id);
            if (userPrivilege != null)
            {
                _context.UserPrivileges.Remove(userPrivilege);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPrivilegeExists(int id)
        {
            return _context.UserPrivileges.Any(e => e.Id == id);
        }
    }
}
