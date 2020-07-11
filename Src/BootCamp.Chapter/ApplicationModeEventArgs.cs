using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ApplicationModeEventArgs : EventArgs
    {
        public DateTime TimeFired { get; }
        public ApplicationModes Mode { get; }

        public ApplicationModeEventArgs(ApplicationModes applicationMode)
        {
            TimeFired = DateTime.Now;
            Mode = applicationMode;
        }
    }
}
