using System;

namespace BootCamp.Chapter.Examples.TvRemoteControllerCommands
{
    public static class TvRemoteControllerCommandsDemo
    {
        public static void Run()
        {
            var tv = new Tv();
            var remoteController = new TvRemoteController(tv);
            remoteController.Toggle();
            remoteController.ChangeChannel(5);
            remoteController.RaiseVolume();
            Console.WriteLine($"{tv.Channel} {tv.IsOn} {tv.Volume}");
        }
    }
}
