using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Constants.DefaultValues;
using Core.Constants.Enums;

namespace Core.CustomException
{
    public class AlivePasswordFailedException : Exception
    {
        public const string MessageError = CoreDefaultStrings.LoginFailedError;

        public AlivePasswordFailedException()
            : base(string.Format(MessageError))
        {
        }

        public ErrorType ErrorType = ErrorType.AlivePasswordFailed;
    }
}
