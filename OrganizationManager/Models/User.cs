using System.ComponentModel.DataAnnotations;
namespace OrganizationManager.Models;

public abstract class User
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Password { get; set; }
    public Company Company { get; set; }
    
}