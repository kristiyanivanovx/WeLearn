using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data;
using WeLearn.Data.Models;

namespace WeLearn.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize(Roles = "Admin")]
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Administration/Reports
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reports.Include(r => r.ApplicationUser).Include(r => r.Comment).Include(r => r.Lesson);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Administration/Reports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.Reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", report.ApplicationUserId);
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Content", report.CommentId);
            ViewData["LessonId"] = new SelectList(_context.Lessons, "Id", "Description", report.LessonId);
            return View(report);
        }

        // POST: Administration/Reports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Subject,Description,ApplicationUserId,LessonId,CommentId,DateCreated,DateDeleted,IsDeleted,Id")] Report report)
        {
            if (id != report.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.Id))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", report.ApplicationUserId);
            ViewData["CommentId"] = new SelectList(_context.Comments, "Id", "Content", report.CommentId);
            ViewData["LessonId"] = new SelectList(_context.Lessons, "Id", "Description", report.LessonId);
            return View(report);
        }

        // GET: Administration/Reports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.Reports
                .Include(r => r.ApplicationUser)
                .Include(r => r.Comment)
                .Include(r => r.Lesson)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: Administration/Reports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            _context.Reports.Remove(report);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(int id)
            => _context.Reports.Any(e => e.Id == id);
    }
}
