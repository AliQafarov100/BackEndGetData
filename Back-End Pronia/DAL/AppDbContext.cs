using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End_Pronia.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
