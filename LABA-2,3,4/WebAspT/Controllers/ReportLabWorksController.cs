using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyDB.Data;
using WebAspT.Models;

namespace WebAspT.Controllers
{
    public class ReportLabWorksController : Controller
    {
        private readonly MyDBContext _context;

        public ReportLabWorksController(MyDBContext context)
        {
            _context = context;
        }

        // GET: ReportLabWorks
        public async Task<IActionResult> Index()
        {
              return _context.ReportLabWork != null ? 
                          View(await _context.ReportLabWork.ToListAsync()) :
                          Problem("Entity set 'MyDBContext.ReportLabWork'  is null.");
        }

        // GET: ReportLabWorks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ReportLabWork == null)
            {
                return NotFound();
            }

            var ReportLabWork = await _context.ReportLabWork
                .FirstOrDefaultAsync(m => m.id_ReportLW == id);
            if (ReportLabWork == null)
            {
                return NotFound();
            }

            return View(ReportLabWork);
        }

        // GET: ReportLabWorks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportLabWorks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_ReportLW,titleReportLW,dateReportLW,versionReportLW,id_Project,id_Student")] ReportLabWork ReportLabWork)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ReportLabWork);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ReportLabWork);
        }

        // GET: ReportLabWorks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ReportLabWork == null)
            {
                return NotFound();
            }

            var ReportLabWork = await _context.ReportLabWork.FindAsync(id);
            if (ReportLabWork == null)
            {
                return NotFound();
            }
            return View(ReportLabWork);
        }

        // POST: ReportLabWorks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("id_ReportLW,titleReportLW,dateReportLW,versionReportLW,id_Project,id_Student")] ReportLabWork ReportLabWork)
        {
            if (id != ReportLabWork.id_ReportLW)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ReportLabWork);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportLabWorkExists(ReportLabWork.id_ReportLW))
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
            return View(ReportLabWork);
        }

        // GET: ReportLabWorks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ReportLabWork == null)
            {
                return NotFound();
            }

            var ReportLabWork = await _context.ReportLabWork
                .FirstOrDefaultAsync(m => m.id_ReportLW == id);
            if (ReportLabWork == null)
            {
                return NotFound();
            }

            return View(ReportLabWork);
        }

        // POST: ReportLabWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.ReportLabWork == null)
            {
                return Problem("Entity set 'MyDBContext.ReportLabWork'  is null.");
            }
            var ReportLabWork = await _context.ReportLabWork.FindAsync(id);
            if (ReportLabWork != null)
            {
                _context.ReportLabWork.Remove(ReportLabWork);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportLabWorkExists(int? id)
        {
          return (_context.ReportLabWork?.Any(e => e.id_ReportLW == id)).GetValueOrDefault();
        }
    }
}
