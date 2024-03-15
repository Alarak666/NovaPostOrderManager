using AuthorizeCore.Constants.DefaultValues;
using AuthorizeCore.Constants.Enums;

namespace AuthorizeCore.CustomException;

public class BadRequestException : Exception
{
    public const string MessageError = CoreDefaultStrings.BadRequestError;

    public BadRequestException()
        : base(string.Format(MessageError))
    {
    }
    public ErrorType ErrorType = ErrorType.BadRequest;
}