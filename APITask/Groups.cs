using System.ComponentModel.DataAnnotations;
namespace APITask;

public class Groups
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public int Rating { get; set; }
    [Required]
    public int Year { get; set; }
}

