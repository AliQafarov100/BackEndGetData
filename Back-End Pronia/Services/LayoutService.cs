using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.DAL;
using Back_End_Pronia.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Pronia.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Setting> GetData()
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync();
            return setting;
        }
    }
}
