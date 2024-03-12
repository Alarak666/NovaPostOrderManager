using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException
{
    public class AuthorizeException : Exception
    {
        public const string MessageError = CoreDefaultStrings.AuthorizeException;

        public AuthorizeException(string? message = null)
            : base(message != null ? string.Format(MessageError) : message)
        {
        }

        public ErrorType ErrorType = ErrorType.AuthorizeFailed;
    }
}