using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class PredicateEventArgs : EventArgs
    {
        

        public PredicateEventArgs(string choice)
        {
            Choice = choice; 
        }

        public string Choice { get; private set; }
    }
}
