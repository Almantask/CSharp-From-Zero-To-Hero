namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class ChangeChanelCommand : ICommandWithParam<int>
    {
        private readonly Tv _tv;

        public ChangeChanelCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute(int channel)
        {
            _tv.Channel = channel;
        }
    }
}