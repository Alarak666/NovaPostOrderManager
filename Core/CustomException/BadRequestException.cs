using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException;

public class BadRequestException : Exception
{
    public const string MessageError = CoreDefaultStrings.BadRequestError;

    public BadRequestException()
        : base(string.Format(MessageError))
    {
    }
    public ErrorType ErrorType = ErrorType.BadRequest;
}