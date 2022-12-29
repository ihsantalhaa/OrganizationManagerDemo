using FluentValidation;

namespace OrganizationManager.Models.Validators;

public class GroupValidator : AbstractValidator<Group>
{
    GroupValidator()
    {
        RuleFor(x => x.GroupName).NotNull().NotEmpty().WithMessage("Grup İsmi Boş Olamaz.")
            .MaximumLength(25).WithMessage("Grup İsmi 25 Karakterden Fazla Olmamalıdır.");
        
        RuleFor(x => x.GroupDescription).NotNull().NotEmpty().WithMessage("Grup Amacı Boş Olamaz.")
            .MaximumLength(60).WithMessage("Grup Amacı 60 Karakterden Fazla Olmamalıdır.");
        //RuleFor(x => x.GroupManager).NotNull().NotEmpty().WithMessage("Lütfen Bir Grup Yöneticisi Seçiniz.");
        RuleFor(x => x.Project).NotNull().NotEmpty().WithMessage("Proje Boş Olamaz.");
        
    }
}