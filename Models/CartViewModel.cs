using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;

public class Cart
{
    [Key]
    public int Id { get; set; }
    [Required]
    public List<Product> Products { get; set; }
    public User? User { get; set; }
}