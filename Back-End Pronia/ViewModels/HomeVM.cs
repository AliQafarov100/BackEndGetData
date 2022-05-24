using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Pronia.Models;

namespace Back_End_Pronia.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Client> Clients { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
