using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class InventoryIsFullException : Exception
    {
        private readonly string _msg;
        
        public InventoryIsFullException(string error)
        {
            _msg = error;
        }

        public override string Message
        {
            get
            {
                return _msg;
            }
        }
    }
}
