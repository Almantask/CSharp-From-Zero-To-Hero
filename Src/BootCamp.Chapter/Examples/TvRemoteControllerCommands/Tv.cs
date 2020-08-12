namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public class Tv
    {
        // Imagine that setting TV state is very complex and is not just changing primitive values.
        public bool IsOn { get; internal set; } = false;
        public int Channel { get; internal set; } = 1;
        public float Volume { get; internal set; } = 50;
    }
}