using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceException() : base("An error at Service level has occurred. Please check the service loggers")
        {
        }

        public ServiceException(string message) : base("An error at Service level has occurred: " + message + ". Please check the service loggers")
        {
        }

        public ServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
