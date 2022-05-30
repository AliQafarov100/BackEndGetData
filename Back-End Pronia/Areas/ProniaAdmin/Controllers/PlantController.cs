using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.DAL;
using Back_End_Pronia.Extensions;
using Back_End_Pronia.Models;
using Back_End_Pronia.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Pronia.Areas.ProniaAdmin.Controllers
{
    [Area("ProniaAdmin")]
    public class PlantController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public PlantController(AppDbContext context,IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            List<Plant> plants = await _context.Plants.Include(p => p.PlantImage).ToListAsync();
            return View(plants);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Plant plant)
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            if (ModelState.IsValid) return View();
            if(plant.IsMain == null || plant.AnotherImages == null)
            {
                ModelState.AddModelError("", "Please enter image format");
                return View();
            }
            if (!plant.IsMain.IsValid(1))
            {
                ModelState.AddModelError("IsMain", "Please choose image file");
                return View();
            }

            plant.PlantImage = new List<PlantImage>();

            foreach(var another in plant.AnotherImages)
            {
                if (!another.IsValid(1))
                {
                    ModelState.AddModelError("AnotherImages", "Please choose image file");
                    return View();
                }
            }

           

            PlantImage newPlant = new PlantImage
            {
                ImagePath = await plant.IsMain.PathFiles(_environment.WebRootPath, @"assets\images\website-images"),
                IsMain = true,
                Plant = plant
            };

            plant.PlantImage.Add(newPlant);

            foreach(var another in plant.AnotherImages)
            {
                PlantImage anotherPlant = new PlantImage
                {
                    ImagePath = await another.PathFiles(_environment.WebRootPath, @"assets\images\website-images"),
                    IsMain = false,
                    Plant = plant
                };

                plant.PlantImage.Add(anotherPlant);
            }

            await _context.Plants.AddAsync(plant);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            Plant plant = await _context.Plants.Include(p => p.PlantImage).FirstOrDefaultAsync(p => p.Id == id);
            return View(plant);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Plant plant = await _context.Plants.Include(p => p.PlantImage).FirstOrDefaultAsync(p => p.Id == id);

            return View(plant);
        }
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            Plant plant = await _context.Plants.Include(p => p.PlantImage).FirstOrDefaultAsync(p => p.Id == id);
            

            if (plant == null)
            {
                return NotFound();
            }
            return View(plant);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeletePlant(int id)
        {
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            Plant plant = await _context.Plants.Include(p => p.PlantImage).FirstOrDefaultAsync(p => p.Id == id);

            if (plant == null) return NotFound();

            _context.Plants.Remove(plant);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
