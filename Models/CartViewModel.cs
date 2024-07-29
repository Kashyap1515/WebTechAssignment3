using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;

public class Cart
{
    [Key]
    public int Id { get; set; }
    [Required]
    public List<ProductItem> Products { get; set; } = new List<ProductItem>();
    public int? UserId { get; set; }
}