using System.Collections.Generic;

namespace GameShop.Models;
public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ManufacturerProducts> ManufacturerProducts { get; set; } = null!;
    }
