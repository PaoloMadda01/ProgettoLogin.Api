using System.ComponentModel.DataAnnotations;

namespace ProgettoLogin.Api;
public class Site
{
    [Key]
    public int id { get; set; }

    public string? Url { get; set; }
}