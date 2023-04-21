using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel;

namespace ProgettoLogin.Api;

[Keyless]
public class MainModel
{
    public int idAccount { get; set; }
    public string? Email { get; set; }
    public List<string?> Name { get; set; } = new();
    public List<DateTime?> DateRecording { get; set; } = new();

    //PASSWORDS
    [Required(ErrorMessage = "Password is required")]
    [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
    [DataType(DataType.Password)]
    public string? PassNow { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
    [DataType(DataType.Password)]
    public string? PassNew { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
    [DataType(DataType.Password)]
    public string? PassNewR { get; set; }

}
