using System.ComponentModel.DataAnnotations;
namespace APITask;

public class Teachers
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Surname { get; set; }
    public DateTime EmploymentDate { get; set; }
    public decimal Premium { get; set; }
    public decimal Salary { get; set; }
}
