using System.ComponentModel.DataAnnotations;

namespace OrganizationManager.Models;

public class Role
{
    [Key]
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public string RoleDescription { get; set; }
    public Company Company { get; set; }
    public Project Project { get; set; }
    public virtual ICollection<Worker> Workers { get; set; }
}