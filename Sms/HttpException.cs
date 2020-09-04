using Kavenegar.Exceptions;

namespace Sms
{
    public class HttpException : KavenegarException
    {
        private readonly int _code;

        public HttpException(string message, int code)
            : base(message) => _code = code;

        public int Code => _code;
    }
}