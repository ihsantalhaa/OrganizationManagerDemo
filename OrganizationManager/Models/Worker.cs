using System.ComponentModel.DataAnnotations;

namespace OrganizationManager.Models;

public class Worker:User
{

    public virtual ICollection<Role> Roles { get; set; }
    public int GroupId { get; set; }
    public virtual ICollection<Group> Groups { get; set; }
    public virtual ICollection<Mission> Missions { get; set; }
}