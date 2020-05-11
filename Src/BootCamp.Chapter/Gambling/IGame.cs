using System.Collections.Generic;

namespace BootCamp.Chapter.Gambling
{
    public interface IGame
    {
        IEnumerable<Player> GetWinners();
    }
}