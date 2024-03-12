using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException
{
    public class PersonPasswordException : Exception
    {
        public const string MessageError = CoreDefaultStrings.PersonPassword;

        public PersonPasswordException()
            : base(string.Format(MessageError))
        {
        }

        public ErrorType ErrorType = ErrorType.PersonPassword;
    }
}
