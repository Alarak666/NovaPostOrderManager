using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using FluentValidation;

namespace ApplicationManager.Validation;

public class AccessValidator : AbstractValidator<CreateInternetDocumentProperty>
{
    public AccessValidator(decimal weight)
    {
        RuleFor(doc => doc.Description).NotEmpty().WithMessage("Опис не повинен бути пустим");
        RuleFor(doc => doc.CitySender).NotEmpty().WithMessage("Місто відправника не повинно бути пустим");
        RuleFor(doc => doc.CityRecipient).NotEmpty().WithMessage("Місто отримувача не повинно бути пустим");
        RuleFor(doc => doc.Sender).NotEmpty().WithMessage("Відправник не повинен бути пустим");
        RuleFor(doc => doc.Recipient).NotEmpty().WithMessage("Отримувач не повинен бути пустим");
        RuleFor(doc => doc.DateTime).NotEmpty().WithMessage("Дата та час не повинні бути пустими");
        RuleFor(doc => doc.ServiceType).NotEmpty().WithMessage("Тип послуги не повинен бути пустим");

        RuleFor(doc => doc.OptionsSeat).NotNull().When(doc => doc.OptionsSeat != null)
            .WithMessage("Параметри місця не повинні бути пустими ");

        When(doc => doc.OptionsSeat != null, () =>
        {
            RuleForEach(doc => doc.OptionsSeat).SetValidator(new OptionsSeatValidator(weight));
        });
    }
    public class OptionsSeatValidator : AbstractValidator<OptionsSeat>
    {
        public OptionsSeatValidator(decimal weight)
        {
            //проверка не пустим
            RuleFor(seat => seat.volumetricVolume).GreaterThan(0).WithMessage("Об'єм не повинен бути пустим");
            RuleFor(seat => seat.volumetricWidth).GreaterThan(0).WithMessage("Ширина не повинна бути пустою");
            RuleFor(seat => seat.volumetricLength).GreaterThan(0).WithMessage("Довжина не повинна бути пустою");
            RuleFor(seat => seat.volumetricHeight).GreaterThan(0).WithMessage("Висота не повинна бути пустою");
            RuleFor(seat => seat.weight).GreaterThan(0).WithMessage("Вага не повинна бути пустою");
            RuleFor(seat => seat).Custom((seat, context) => {
                var sidesGreaterThan70 = 0;
                var propertyWithIssue = ""; // Добавляем переменную для хранения имени свойства
                if (seat.volumetricWidth > 70) { sidesGreaterThan70++; propertyWithIssue = nameof(seat.volumetricWidth); }
                if (seat.volumetricLength > 70) { sidesGreaterThan70++; propertyWithIssue = sidesGreaterThan70 > 1 ? propertyWithIssue + $", {nameof(seat.volumetricLength)}" : $"{nameof(seat.volumetricLength)}"; }
                if (seat.volumetricHeight > 70) { sidesGreaterThan70++; propertyWithIssue = sidesGreaterThan70 > 1 ? propertyWithIssue + $", {nameof(seat.volumetricHeight)}" : $"{nameof(seat.volumetricHeight)}"; }

                if (sidesGreaterThan70 > 1)
                {
                    context.AddFailure(propertyWithIssue,"Только одна сторона может быть больше 70 см");
                }
            });
            RuleFor(seat => seat).Custom((seat, context) =>
            {
                var volumetricWeight = (decimal)(seat.volumetricWidth * seat.volumetricLength * seat.volumetricHeight) / 4000;
                if (volumetricWeight > weight)
                {
                    context.AddFailure(nameof(seat.weight), $"Дозволена максимальна вага: {weight}, об'ємна вага теж не повинна перевищувати це значення");
                }
            });
        }
    }
}