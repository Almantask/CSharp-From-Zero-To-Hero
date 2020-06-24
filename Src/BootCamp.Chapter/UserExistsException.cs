using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Throws an exception when a new user with the same username as an existing user tries to be registered
    /// </summary>
    class UserExistsException : Exception
    {
        public override string Message
        {
            get { return "This user already exists."; }

        }
    }
}
