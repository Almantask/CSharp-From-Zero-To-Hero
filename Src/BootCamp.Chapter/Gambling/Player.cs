using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Gambling
{
    public class Player
    {
        public string Name { get; }
        public Hand Hand { get; }

        public Player(string name, Hand hand)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Hand = hand ?? throw new ArgumentNullException(nameof(hand));
        }
    }
}
