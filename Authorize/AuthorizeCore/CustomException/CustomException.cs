using AuthorizeCore.Constants.DefaultValues;
using AuthorizeCore.Constants.Enums;

namespace AuthorizeCore.CustomException;

public class CustomException : Exception
{
    public const string MessageError = CoreDefaultStrings.CustomExceptionText;

    public CustomException()
        : base(string.Format(MessageError))
    {
    }

    public ErrorType ErrorType = ErrorType.Customer;
}