using System.ComponentModel.DataAnnotations;
namespace APITask;

public class Faculties
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
}
