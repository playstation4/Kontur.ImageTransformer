using System;

namespace Kontur.ImageTransformer.Infrastucture.Exceptions
{
    internal class ValidationServiceException : ServiceException
    {
        public ValidationServiceException()
        {
        }

        public ValidationServiceException(string message) : base(message)
        {
        }

        public ValidationServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
