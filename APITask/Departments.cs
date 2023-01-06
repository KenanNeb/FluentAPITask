using System.ComponentModel.DataAnnotations;
namespace APITask;

public class Departments
{
    public int Id { get; set; }
    public decimal Financing { get; set; }
    [Required]
    public string? Name { get; set; }
}
