using BootCamp.Chapter.Gambling;
using BootCamp.Chapter.Gambling.Poker;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {

        static void Main(string[] args)
        {
            var game = new Poker();
            var outcome = game.GetWinners();
             
        }

    }
}
