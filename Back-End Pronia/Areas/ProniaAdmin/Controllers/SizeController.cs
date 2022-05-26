using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Back_End_Pronia.Models;
using Size = Back_End_Pronia.Models.Size;

namespace Back_End_Pronia.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class SizeController : Controller
    {
        private readonly AppDbContext _context;

        public SizeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Back_End_Pronia.Models.Size> sizes = await _context.Sizes.ToListAsync();
            return View(sizes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Size size)
        {
            if (!ModelState.IsValid) return View();

            await _context.Sizes.AddAsync(size);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int id)
        {
            return Json(id);
        }
        public IActionResult Edit(int id)
        {
            return Json(id);
        }
        public IActionResult Delete(int id)
        {
            return Json(id);
        }
    }
}
