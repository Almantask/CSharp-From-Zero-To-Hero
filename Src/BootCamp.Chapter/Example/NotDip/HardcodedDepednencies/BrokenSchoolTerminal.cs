using System;
using BootCamp.Chapter.Ref;

namespace BootCamp.Chapter.Example.NotDip
{
    public class BrokenSchoolTerminal : ISchoolTerminal
    {
        private readonly ISpeaker _speaker;

        public BrokenSchoolTerminal()
        {
            _speaker = new BrokenSpeaker();
        }

        public void Start()
        {
            _speaker.Announce();
        }
    }

    public class BrokenSpeaker : ISpeaker
    {
        public void Announce() => Console.WriteLine("----Broken----");
    }

    internal interface ISpeaker
    {
        void Announce();
    }
}
