using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.DAL;
using Back_End_Pronia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Pronia.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Setting set = await _context.Settings.FirstOrDefaultAsync();

            return View(set);
        }
    }
}
