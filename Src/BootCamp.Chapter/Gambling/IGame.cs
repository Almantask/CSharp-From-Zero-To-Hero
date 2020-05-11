using System.Collections.Generic;

namespace BootCamp.Chapter.Gambling.Poker
{
    public interface IGame
    {
        IEnumerable<Player> GetWinners();
    }
}