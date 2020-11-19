using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        private readonly string error;
        public override string Message
        {
            get
            {
                return error;
            }
        }
        public InvalidBalancesException() { }

        public InvalidBalancesException(string msg)
        {
            this.error = msg;
        }
        public InvalidBalancesException(string msg,Exception innerException)
        {
            this.error = msg;
            throw innerException;
        }
    }
}