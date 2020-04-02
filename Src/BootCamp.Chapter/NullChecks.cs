using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class NullChecks
    {
        public static void StringNullChecks(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException($"{nameof(name)} can't be null.");
            }
        }
    }
}
