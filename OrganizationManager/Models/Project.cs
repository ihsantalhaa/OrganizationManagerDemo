using System.ComponentModel.DataAnnotations;

namespace OrganizationManager.Models;

public class Project
{
    [Key]
    public int ProjectId { get; set; }
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public Worker ProjectManager { get; set; }
    public int CpompanyId { get; set; }
    public Company Company { get; set; }
    public virtual ICollection<Group> Groups { get; set; }

}