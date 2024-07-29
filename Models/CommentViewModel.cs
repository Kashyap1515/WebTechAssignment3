using System.ComponentModel.DataAnnotations;
namespace assignment3.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int UserId { get; set; }
    public int? Rating { get; set; }
    public string? Image { get; set; }
    [Required]
    public string Text { get; set; }
}