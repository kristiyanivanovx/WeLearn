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
    public class LessonsController : Controller
    {
        private readonly ApplicationDbContext context;

        public LessonsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: Administration/Lessons
        public async Task<IActionResult> Index()
        {
            //var lessonsViewModels = await lessonsService.GetAllLessonsToVMAsync();
            //return View(lessonsViewModels);
            var applicationDbContext = context.Lessons
                .Include(l => l.ApplicationUser)
                .Include(l => l.Category)
                .Include(l => l.Material)
                .Include(l => l.Video);
            var items = await applicationDbContext.ToListAsync();
            return View(items);
        }

        // GET: Administration/Lessons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await context.Lessons
                .Include(l => l.ApplicationUser)
                .Include(l => l.Category)
                .Include(l => l.Material)
                .Include(l => l.Video)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // GET: Administration/Lessons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await context.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id", lesson.ApplicationUserId);
            ViewData["CategoryId"] = new SelectList(context.Categories, "Id", "Name", lesson.CategoryId);
            ViewData["MaterialId"] = new SelectList(context.Materials, "Id", "Link", lesson.MaterialId);
            ViewData["VideoId"] = new SelectList(context.Videos, "Id", "ContentType", lesson.VideoId);
            return View(lesson);
        }

        // POST: Administration/Lessons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,CategoryId,Grade,ApplicationUserId,VideoId,MaterialId,DateCreated,DateModified,DateDeleted,IsDeleted,Id")] Lesson lesson)
        {
            if (id != lesson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(lesson);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonExists(lesson.Id))
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
            ViewData["ApplicationUserId"] = new SelectList(context.ApplicationUsers, "Id", "Id", lesson.ApplicationUserId);
            ViewData["CategoryId"] = new SelectList(context.Categories, "Id", "Name", lesson.CategoryId);
            ViewData["MaterialId"] = new SelectList(context.Materials, "Id", "Link", lesson.MaterialId);
            ViewData["VideoId"] = new SelectList(context.Videos, "Id", "ContentType", lesson.VideoId);
            return View(lesson);
        }

        // GET: Administration/Lessons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await context.Lessons
                .Include(l => l.ApplicationUser)
                .Include(l => l.Category)
                .Include(l => l.Material)
                .Include(l => l.Video)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: Administration/Lessons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lesson = await context.Lessons.FindAsync(id);
            context.Lessons.Remove(lesson);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LessonExists(int id)
        {
            return context.Lessons.Any(e => e.Id == id);
        }
    }
}
