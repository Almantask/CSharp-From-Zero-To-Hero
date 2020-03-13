using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        private string _Msg;
        public InvalidBalancesException(string err)
        {
            _Msg = err;
        }
        public override string Message
        {
            get
            {
                return _Msg;
            }

        }
    }
}