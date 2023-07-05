namespace GameShop.Models;
public class ManufacturerProducts
{
    public int ManufacturerProductsId { get; set; }
    public Manufacturer Manufacturer { get; set; } = null!;
    public Products Products { get; set; } = null!;
}
