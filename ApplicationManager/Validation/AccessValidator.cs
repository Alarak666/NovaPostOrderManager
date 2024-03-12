using Core.Constants.DefaultValues;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using FluentValidation;

namespace ApplicationManager.Validation;

public class AccessValidator : AbstractValidator<CreateInternetDocumentProperty>
{
    public AccessValidator()
    {
        RuleFor(doc => doc.Description).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.CitySender).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.CityRecipient).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.Sender).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.Recipient).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.DateTime).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.Weight).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
        RuleFor(doc => doc.ServiceType).NotEmpty().WithMessage(CoreDefaultStrings.FieldEmpty);
    }
}