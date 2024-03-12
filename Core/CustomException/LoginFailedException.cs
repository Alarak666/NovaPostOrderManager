using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException
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
