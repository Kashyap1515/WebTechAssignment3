using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;

public class Order
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public List<ProductItem> Products { get; set; }
    public decimal? TotalCost { get; set; }
    public DateTime? Date { get; set; }
}
