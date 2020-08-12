using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public interface ICommandWithParam<in TParam>
    {
        void Execute(TParam param);
    }
}
