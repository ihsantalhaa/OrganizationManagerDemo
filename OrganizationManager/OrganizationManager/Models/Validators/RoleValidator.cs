using FluentValidation;
namespace OrganizationManager.Models.Validators;

public class RoleValidator : AbstractValidator<Role>
{
    RoleValidator()
    {
        RuleFor(x => x.RoleName).NotNull().NotEmpty().WithMessage("Rol İsmi Boş Olamaz");
        RuleFor(x => x.RoleName).MaximumLength(25).WithMessage("Rol İsmi 25 Karakterden Az Olmalıdır.");
        
        RuleFor(x => x.RoleDescription).NotNull().NotEmpty().WithMessage("Rol İsmi Boş Olamaz");
        RuleFor(x => x.RoleDescription).MaximumLength(60).WithMessage("Rol İsmi 60 Karakterden Az Olmalıdır.");
    }
}