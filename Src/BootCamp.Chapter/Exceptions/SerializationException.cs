using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class SerializationException : Exception
    {
        public SerializationException()
        {
        }

        public SerializationException(string message) : base(message)
        {
        }

        public SerializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
