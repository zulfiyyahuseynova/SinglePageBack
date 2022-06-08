using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SinglePage.DAL;
using SinglePage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Abouts = await _context.Abouts.ToListAsync(),
                Awards = await _context.Awards.ToListAsync(),
                Educations = await _context.Educations.ToListAsync(),
                Experiences = await _context.Experiences.ToListAsync(),
                Interests = await _context.Interests.ToListAsync(),
                ProgLangs = await _context.ProgLangs.ToListAsync(),
                Workflows = await _context.Workflows.ToListAsync()
            };
            return View(homeVM);
        }
    }
}
