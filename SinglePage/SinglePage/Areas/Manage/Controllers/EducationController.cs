using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SinglePage.DAL;
using SinglePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize]
    public class EducationController : Controller
    {
        private AppDbContext _context { get; }
        public EducationController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Education> educations = await _context.Educations.ToListAsync();
            return View(educations);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Education education)
        {
            if (_context.Educations.FirstOrDefault(e => e.Title1.ToLower().Trim() == education.Title1.ToLower().Trim()) != null) return RedirectToAction(nameof(Index));
            await _context.Educations.AddAsync(education);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Education education = _context.Educations.FirstOrDefault(x => x.Id == id);
            if (education == null) return NotFound();

            return View(education);
        }

        [HttpPost]
        public IActionResult Edit(Education education)
        {
            Education existEducation = _context.Educations.FirstOrDefault(x => x.Id == education.Id);
            if (existEducation == null) return NotFound();

            existEducation.Title1 = education.Title1;
            existEducation.Title2 = education.Title2;
            existEducation.Description = education.Description;
            existEducation.Context = education.Context;
            existEducation.Date = education.Date;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Education education = _context.Educations.Find(id);
            if (education == null) return NotFound();
            _context.Educations.Remove(education);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
