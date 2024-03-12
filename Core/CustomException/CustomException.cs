using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException;

public class CustomException : Exception
{
    public const string MessageError = CoreDefaultStrings.CustomExceptionText;

    public CustomException(string message)
        : base(string.Format(MessageError, message))
    {
    }

    public ErrorType ErrorType = ErrorType.Customer;
}