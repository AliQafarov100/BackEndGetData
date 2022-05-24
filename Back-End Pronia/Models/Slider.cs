using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End_Pronia.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public byte DisCount { get; set; }
        public string DiscoverUrl { get; set; }
    }
}
