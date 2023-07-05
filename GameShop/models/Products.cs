using System.Collections;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
namespace GameShop.Models;
public class Products
{
    /*'id' indicates that the field is a primary key. */
    public int ProductsId { get; set; }
    /*null! means that the field cannot be nullable */
    public string Name { get; set; } = null!;
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
    public int PlayerNumbers { get; set; }
    public int StorageNumber { get; set; }
    public State State { get; set; } = null!;
    public GameType Game { get; set; } = null!;
    public ICollection<ManufacturerProducts> ManufacturerProducts { get; set; }
    /*public ICollection<Table> Table {get; set;} = null!; Creates a one to many relationship. Ie. One the product can have many Table, while the
     table has exactly 1 Products*/
}
