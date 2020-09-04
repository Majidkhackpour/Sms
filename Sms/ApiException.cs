using Services;
using Kavenegar.Exceptions;

namespace Sms
{
    public class ApiException : KavenegarException
    {
        readonly MetaCode _result;

        public ApiException(string message, int code)
            : base(message) => _result = (MetaCode) code;

        public MetaCode Code => _result;
    }
}
