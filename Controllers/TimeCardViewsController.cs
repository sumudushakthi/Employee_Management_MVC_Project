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
    public class TimeCardViewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimeCardViewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TimeCardViews
        public async Task<IActionResult> Index()
        {
            return View(await _context.TimeCardViews.ToListAsync());
        }

        // GET: TimeCardViews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeCardView = await _context.TimeCardViews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeCardView == null)
            {
                return NotFound();
            }

            return View(timeCardView);
        }

        // GET: TimeCardViews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeCardViews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,location,Year,Month,Day")] TimeCardView timeCardView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeCardView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeCardView);
        }

        // GET: TimeCardViews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeCardView = await _context.TimeCardViews.FindAsync(id);
            if (timeCardView == null)
            {
                return NotFound();
            }
            return View(timeCardView);
        }

        // POST: TimeCardViews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,location,Year,Month,Day")] TimeCardView timeCardView)
        {
            if (id != timeCardView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeCardView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeCardViewExists(timeCardView.Id))
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
            return View(timeCardView);
        }

        // GET: TimeCardViews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeCardView = await _context.TimeCardViews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeCardView == null)
            {
                return NotFound();
            }

            return View(timeCardView);
        }

        // POST: TimeCardViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeCardView = await _context.TimeCardViews.FindAsync(id);
            if (timeCardView != null)
            {
                _context.TimeCardViews.Remove(timeCardView);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeCardViewExists(int id)
        {
            return _context.TimeCardViews.Any(e => e.Id == id);
        }
    }
}
