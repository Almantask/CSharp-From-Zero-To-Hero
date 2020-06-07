using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Gambling
{
    public abstract class CardGame : IGame
    {
        public IReadOnlyList<Player> Players => _players;
        private readonly List<Player> _players;

        public void AddPlayer(Player player)
        {
            _players.Add(player ?? throw new ArgumentNullException(nameof(player)));
        }

        public void RemovePlayer(string name)
        {
            _players.RemoveAll((player => player.Name == name));
        }

        public abstract IEnumerable<Player> GetWinners();
    }
}