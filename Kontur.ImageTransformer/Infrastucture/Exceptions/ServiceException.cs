using System;

namespace Kontur.ImageTransformer.Infrastucture.Exceptions
{
    public abstract class ServiceException : Exception
    {
        protected ServiceException() {}
        protected ServiceException(string message) : base(message) { }
        protected ServiceException(string message, Exception innerException) : base(message, innerException) { }
    }
}
