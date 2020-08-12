namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class TvRemoteController
    {
        private readonly Tv _tv;
        private readonly ICommand _raiseVolumeCommand;
        private readonly ICommand _lowerChangeVolumeCommand;
        private readonly ICommand _toggleCommand;
        private readonly ICommandWithParam<int> _changeChannelCommand;

        // Commands won't change 100%
        // They will always depend on just a Tv
        public TvRemoteController(Tv tv)
        {
            _tv = tv;
            // Hardcoding the commands might not be the best solution.
            // However, in this specific example, the benefits are little for injecting them:
            // Tv can still be tested, commands won't change (their implementation can change,
            // but there won't be multiple implementations for the same)
            _raiseVolumeCommand = new ChangeVolumeCommand(tv, 1);
            _lowerChangeVolumeCommand = new ChangeVolumeCommand(tv, -1);
            _toggleCommand = new ToggleCommand(tv);
            _changeChannelCommand = new ChangeChanelCommand(tv);
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
