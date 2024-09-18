using FluentValidation;
using HotelierProject.WebUI.Dtos.GuestDto;

namespace HotelierProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Konuk adı boş olmamalıdır.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Konuk adı en az 2 karakter olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Konuk adı en fazla 20 karakter olmalıdır.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Konuk soyadı boş olmamalıdır.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Konuk soyadı en az 2 karakter olmalıdır.");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Konuk soyadı en fazla 20 karakter olmalıdır.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Lütfen bir şehir giriniz.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir en az 3 karakter olmalıdır.");
            RuleFor(x => x.City).MaximumLength(14).WithMessage("Şehir adı en fazla 14 karakter olmalıdır.");

        }
    }
}
