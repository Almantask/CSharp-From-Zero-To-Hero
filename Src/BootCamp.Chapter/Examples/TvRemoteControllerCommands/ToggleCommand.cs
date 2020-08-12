namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class ToggleCommand : ICommand
    {
        private readonly Tv _tv;

        public ToggleCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.IsOn = !_tv.IsOn;
        }
    }
}