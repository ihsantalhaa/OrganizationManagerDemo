using FluentValidation;
namespace OrganizationManager.Models.Validators;

public class CompanyValidator : AbstractValidator<Company>
{
    public CompanyValidator()
    {
        RuleFor(x => x.CompanyName).NotNull().NotEmpty().WithMessage("Şirket İsmi Boş Olamaz.")
            .MaximumLength(25).WithMessage("Şirket İsmi 25 Karakterden Fazla Olmamalıdır.");
        RuleFor(x => x.EstablishmentDate).NotNull().NotEmpty().WithMessage("Şirket Kuruluş Tarihi Boş Olamaz.");
        RuleFor(x => x.CompanyOwner).NotNull().NotEmpty();
    }
}