using AuthorizeCore.Constants.DefaultValues;
using AuthorizeCore.Constants.Enums;

namespace AuthorizeCore.CustomException
{
    public class LivePasswordFailedException : Exception
    {
        public const string MessageError = CoreDefaultStrings.LivePasswordBad;

        public LivePasswordFailedException()
            : base(string.Format(MessageError))
        {
        }

        public ErrorType ErrorType = ErrorType.LivePasswordLeft;
    }
}
