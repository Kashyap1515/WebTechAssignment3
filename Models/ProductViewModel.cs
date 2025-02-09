using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    public string? Image { get; set; }

    [Required]
    public decimal Pricing { get; set; }

    public decimal ShippingCost { get; set; }
}

public class ProductItem
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }
    public int Quanity { get; set; }
}

