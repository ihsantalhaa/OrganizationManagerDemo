using Microsoft.AspNetCore.Mvc.ApplicationModels;
using OrganizationManager.Models;

public class CompanyOwner : User
{
    public int CompanyId { get; set; }
}