using System.ComponentModel.DataAnnotations;

namespace TestWebApi.Models;

public class Person
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; } = null!;

    [Range(0, 120, ErrorMessage = "Age must be between 0 and 120.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Town is required.")]
    [StringLength(100, ErrorMessage = "Town cannot exceed 100 characters.")]
    public string Town { get; set; } = null!;
}
