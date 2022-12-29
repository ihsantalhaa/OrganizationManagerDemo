using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrganizationManager.Models;

public class Company
{
    [Key]
    public int CompanyId { get; set; }
    public string CompanyName { get; set; }
    public DateTime EstablishmentDate { get; set; }
    public CompanyOwner CompanyOwner { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
}