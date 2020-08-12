namespace BootCamp.Chapter.Examples.FunctionalTvRemoteControllerCommands
{
    public class TvRemoteBuilder
    {
        public static TvRemoteController Build(Tv tv) =>
        new TvRemoteController(
            () => ReallyComplexCommands.IncrementVolume(tv, 1),
            () => ReallyComplexCommands.IncrementVolume(tv, -1),
            () => tv.IsOn = !tv.IsOn,
            (channel) => tv.Channel = channel);
    }
}
