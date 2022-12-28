using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganizationManager.Models;

public class Group
{
    [Key]
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public string GroupDescription { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    [NotMapped]
    public Worker GroupManager { get; set; }
    public virtual ICollection<Worker> Workers { get; set; }
}