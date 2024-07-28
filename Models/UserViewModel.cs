using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Username { get; set; }

    public string? ShippingAddress { get; set; }

    public List<string>? PurchaseHistory { get; set; }
}
