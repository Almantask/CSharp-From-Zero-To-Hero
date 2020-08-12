namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class TvRemote
    {
        private readonly Tv _tv;
        private readonly ICommand _raiseVolumeCommand;
        private readonly ICommand _lowerChangeVolumeCommand;
        private readonly ICommand _toggleCommand;
        private readonly ICommandWithParam<int> _changeChannelCommand;

        // Commands won't change 100%
        // They will always depend on just a Tv
        public TvRemote(Tv tv, ICommand raiseVolumeCommand, ICommand lowerChangeVolumeCommand, ICommand toggleCommand, ICommandWithParam<int> changeChannelCommand)
        {
            _tv = tv;
            _raiseVolumeCommand = raiseVolumeCommand;
            _lowerChangeVolumeCommand = lowerChangeVolumeCommand;
            _toggleCommand = toggleCommand;
            _changeChannelCommand = changeChannelCommand;
        }

        // Imagine that each operation for TV is extremely complex.
        // So complex, that each operation needs its' own class (hundreds of lines of code)
        // However, a remote controller simply invokes those complex operations.
        // No matter how complex it gets, the remote controller will remain THE SAME!
        public void RaiseVolume() => _raiseVolumeCommand.Execute();

        public void LowerVolume() => _lowerChangeVolumeCommand.Execute();

        public void Toggle() => _toggleCommand.Execute();

        public void ChangeChannel(int channel) => _changeChannelCommand.Execute(channel);
    }
}
