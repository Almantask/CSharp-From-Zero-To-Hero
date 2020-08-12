using System;

namespace BootCamp.Chapter.Examples.FunctionalTvRemoteControllerCommands
{
    public class TvRemoteController
    {
        private readonly TvRemoteControllerCommands.Tv _tv;
        private readonly Action _raiseVolumeCommand;
        private readonly Action _lowerVolumeCommand;
        private readonly Action _toggleCommand;
        private readonly Action<int> _changeChannelCommand;

        // Commands won't change 100%
        // They will always depend on just a Tv
        public TvRemoteController(Action raiseVolume, Action lowerVolume, Action toggle, Action<int> changeChannel)
        {
            _raiseVolumeCommand = raiseVolume;
            _lowerVolumeCommand = lowerVolume;
            _toggleCommand = toggle;
            _changeChannelCommand = changeChannel;
        }

        // Imagine that each operation for TV is extremely complex.
        // So complex, that each operation needs its' own class (hundreds of lines of code)
        // However, a remote controller simply invokes those complex operations.
        // No matter how complex it gets, the remote controller will remain THE SAME!
        public void RaiseVolume() => RaiseVolume();

        public void LowerVolume() => LowerVolume();

        public void Toggle() => Toggle();

        public void ChangeChannel(int channel) => ChangeChannel(channel);
    }
}
