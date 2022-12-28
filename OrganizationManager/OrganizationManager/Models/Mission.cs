using System.ComponentModel.DataAnnotations;

namespace OrganizationManager.Models;

public class Mission
{
    [Key]
    public int MissionId { get; set; }
    public String Title { get; set; }
    public String Description { get; set; }

    public int MissionWorkerId { get; set; }
    public Worker Worker { get; set; }
}