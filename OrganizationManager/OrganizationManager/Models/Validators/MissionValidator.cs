using FluentValidation;

namespace OrganizationManager.Models.Validators;

public class MissionValidator : AbstractValidator<Mission>
{
    MissionValidator()
    {
        RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Görev Başlığı Boş Olamaz.")
            .MaximumLength(25).WithMessage("Görev Başlığı 25 Karakterden Fazla Olmalıdır.");
        RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Görev Açıklaması Boş Olamaz.")
            .MaximumLength(60).WithMessage("Görev Başlığı 60 Karakterden Fazla Olmalıdır.");
        RuleFor(x=>x.Worker).NotNull().NotEmpty().WithMessage("Görevin Birine Veya Bir Gruba Ait Olmalıdır.");
    }
}