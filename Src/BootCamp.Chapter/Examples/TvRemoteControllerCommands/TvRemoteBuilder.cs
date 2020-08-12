using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class TvRemoteBuilder
    {
        public static TvRemote Build(Tv tv)
        {
            var raiseVolumeCommand = new ChangeVolumeCommand(tv, 1);
            var lowerChangeVolumeCommand = new ChangeVolumeCommand(tv, -1);
            var toggleCommand = new ToggleCommand(tv);
            var changeChannelCommand = new ChangeChanelCommand(tv);

            return new TvRemote(tv, raiseVolumeCommand, lowerChangeVolumeCommand, toggleCommand, changeChannelCommand);
        }
    }
}
