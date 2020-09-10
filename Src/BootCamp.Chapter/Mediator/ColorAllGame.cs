using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Mediator
{
    public interface IColorAllGame
    {
        bool IsComplete();
    }

    public class ColorAllGame : IColorAllGame
    {
        private ITile[] _tiles;

        public ColorAllGame(IEnumerable<ITile> tiles)
        {
            _tiles = tiles.ToArray();
        }

        public ColorAllGame()
        {
            _tiles = new ITile[0];
        }

        public void SetTiles(IEnumerable<ITile> tiles)
        {
            _tiles = tiles.ToArray();
        }

        public bool IsComplete()
        {
            var isGameComplete = _tiles.All(t => t.IsColored);
            if (isGameComplete)
            {
                Console.WriteLine("Congratulations! You won!");
            }

            return isGameComplete;
        }

        public void Press(int tileIndex)
        {
            if (tileIndex >= _tiles.Length ||
                tileIndex < 0)
            {
                throw new InvalidGameSetupException(tileIndex);
            }
            _tiles[tileIndex].Toggle();
        }
    }
}
