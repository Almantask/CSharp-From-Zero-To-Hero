using System;
using System.Runtime.Serialization;

namespace BootCamp.Chapter.Exceptions
{
    [Serializable]
    public class InvalidBuildingHeightException : Exception
    {
        public InvalidBuildingHeightException()
        {
        }

        public InvalidBuildingHeightException(string message) : base(message)
        {
        }

        public InvalidBuildingHeightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBuildingHeightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}