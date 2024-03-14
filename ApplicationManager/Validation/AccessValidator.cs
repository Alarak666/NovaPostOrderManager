using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using FluentValidation;

namespace ApplicationManager.Validation;

public class AccessValidator : AbstractValidator<CreateInternetDocumentProperty>
{
    public AccessValidator()
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

        When(doc => doc.OptionsSeat == null, () =>
        {
            RuleFor(doc => doc.Weight).Must(x=> decimal.Parse(x) > 0).WithMessage("Вага більше 0");
            RuleFor(doc => doc.VolumeGeneral).Must(x => decimal.Parse(x) > 0).WithMessage("Загальний об’єм більше 0");
        });
        
        When(doc => doc.OptionsSeat != null, () =>
        {
            RuleForEach(doc => doc.OptionsSeat).SetValidator(new OptionsSeatValidator());
        });
    }
    public class OptionsSeatValidator : AbstractValidator<OptionsSeat>
    {
        public OptionsSeatValidator()
        {
            RuleFor(seat => seat.volumetricVolume).GreaterThan(0).WithMessage("Об'єм не повинен бути пустим");
            RuleFor(seat => seat.volumetricWidth).GreaterThan(0).WithMessage("Ширина не повинна бути пустою");
            RuleFor(seat => seat.volumetricLength).GreaterThan(0).WithMessage("Довжина не повинна бути пустою");
            RuleFor(seat => seat.volumetricHeight).GreaterThan(0).WithMessage("Висота не повинна бути пустою");
            RuleFor(seat => seat.weight).GreaterThan(0).WithMessage("Вага не повинна бути пустою");
        }
    }
}