using System;

namespace BootCamp.Chapter.V2
{
    public class Legs
    {
        private string _message;
        private int _repeatTimes;

        public Legs(string message, int times)
        {
            _message = message;
            _repeatTimes = times;
        }

        public void Walk()
        {
            for (int i = 0; i < _repeatTimes; i++)
            {
                Console.WriteLine(_message);
            }
        }
    }
}