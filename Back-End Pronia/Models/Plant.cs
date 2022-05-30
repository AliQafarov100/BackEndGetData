using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Back_End_Pronia.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string SKU { get; set; }
        public string Shipping { get; set; }
        [Required]
        public string Request { get; set; }
        [Required]
        public string Guarantee { get; set; }
        
        public int? ColorId { get; set; }
        public Color color { get; set; }

        public int? SizeId { get; set; }
        public Size size { get; set; }
        public List<PlantImage> PlantImage { get; set; }
        [NotMapped]

        public IFormFile IsMain { get; set; }
        [NotMapped]
        public List<IFormFile> AnotherImages { get; set; }

    }
}
