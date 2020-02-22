using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BootCamp.Chapter.V2
{
    public class Head
    {
        private string _message;
        private int _repeatTimes;

        public Head(string message, int times)
        {
            _message = message;
            _repeatTimes = times;
        }

        public void Talk()
        {
            for (int i = 0; i < _repeatTimes; i++)
            {
                Console.WriteLine(_message);
            }
        }
    }
}
