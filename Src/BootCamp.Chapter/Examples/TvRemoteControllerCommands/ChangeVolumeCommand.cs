using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class ChangeVolumeCommand : ICommand
    {
        private readonly Tv _tv;
        private readonly float _change;

        public ChangeVolumeCommand(Tv tv, float change)
        {
            _tv = tv;
            _change = change;
        }

        public void Execute()
        {
            _tv.Volume+= _change;
        }
    }
}
