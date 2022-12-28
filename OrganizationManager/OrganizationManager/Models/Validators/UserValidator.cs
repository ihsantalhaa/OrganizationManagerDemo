using System.Text.RegularExpressions;
using FluentValidation;

namespace OrganizationManager.Models.Validators;

public class UserValidator : AbstractValidator<User>
{
    UserValidator()
    {
        RuleFor(x=>x.Name).NotNull().NotEmpty().WithMessage("İsim Boş Olamaz.");
        RuleFor(x => x.Name).MaximumLength(15).WithMessage("İsmi 15 Karakterden Az Olmalıdır.");
        
        RuleFor(x=>x.Surname).NotNull().NotEmpty().WithMessage("Soyisim Boş Olamaz.");
        RuleFor(x => x.Surname).MaximumLength(15).WithMessage("Soyisim 15 Karakterden Az Olmalıdır.");
        
        RuleFor(x => x.Mail).NotNull().NotEmpty().WithMessage("Mail Boş Olamaz.");
        RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir Mail Adresi Giriniz.");
        
        RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Şifre Boş Olamaz");
        RuleFor(x => x.Password)
            .Matches("[A-Z]").WithMessage("Şifre En Az 1 Büyük Harf İçermelidir.")
            .Matches("[a-z]").WithMessage("Şifre En Az 1 Küçük Harf İçermelidir.")
            .Matches("[0-9]").WithMessage("Şifre En Az 1 Rakam İçermelidir.");
            
        RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifre En Az 8 Haneli Olmalıdır.");

        RuleFor(x => x.Phone).NotNull().NotEmpty().WithMessage("Lütfen Bir Telefon Numarası Giriniz.")
            .MinimumLength(10).MaximumLength(10).WithMessage("Girilen Telefon Numarası 10 Haneli Olmalı 0 ile başlamamalıdır.").
            Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("Girilien Telefon Numarası Geçerli Olmalıdır.");
        RuleFor(x => x.Company).NotNull().NotEmpty();

    }
}