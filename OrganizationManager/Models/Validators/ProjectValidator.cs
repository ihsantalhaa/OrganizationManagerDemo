using FluentValidation;

namespace OrganizationManager.Models.Validators;

public class ProjectValidator : AbstractValidator<Project>
{
    ProjectValidator()
    {
        RuleFor(x => x.ProjectName).NotNull().NotEmpty().WithMessage("Proje İsmi Boş Olamaz.")
            .MaximumLength(25).WithMessage("Proje İsmi 25 Karakterden Fazla Olmamalıdır.");
        
        RuleFor(x => x.ProjectDescription).NotNull().NotEmpty().WithMessage("Proje Açıklaması Boş Olamaz.")
            .MaximumLength(60).WithMessage("Proje İsmi 60 Karakterden Fazla Olmamalıdır.");
        
        //RuleFor(x => x.ProjectManager).NotNull().NotEmpty().WithMessage("Proje Yöneticisi Boş Olamaz.");
        RuleFor(x => x.Company).NotNull().NotEmpty().WithMessage("Şirket Boş Olamaz.");
    }
}