using AuthorizeCore.Constants.DefaultValues;
using AuthorizeCore.Constants.Enums;

namespace AuthorizeCore.CustomException
{
    public class LoginFailedException : Exception
    {
        public const string MessageError = CoreDefaultStrings.LoginFailedError;

        public LoginFailedException()
            : base(string.Format(MessageError))
        {
        }

        public ErrorType ErrorType = ErrorType.LoginFailed;
    }
}
