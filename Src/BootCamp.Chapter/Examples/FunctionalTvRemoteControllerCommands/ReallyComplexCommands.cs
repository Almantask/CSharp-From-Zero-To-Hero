using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.FunctionalTvRemoteControllerCommands
{
    class ReallyComplexCommands
    {
        public static void IncrementVolume(Tv tv, float value)
        {
            if (tv.IsOn)
            {
                tv.Volume += value;
                if(tv.Volume > 100)
                {
                    tv.Volume = 100;
                }
                else if(tv.Volume < 0)
                {
                    tv.Volume = 0;
                }
            }
        }
    }
}
