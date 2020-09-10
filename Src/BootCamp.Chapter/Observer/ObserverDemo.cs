using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Observer
{
    public static class ObserverDemo
    {
        public static void Run()
        {
            var tiles = BuildTiles(5).ToArray();
            var game = new ColorAllGame(tiles);
            foreach (var tile in tiles)
            {
                tile.Attach(game);
            }

            var isContinue = true;
            while (isContinue)
            {
                Console.Write("Gues a tile!: ");
                isContinue = int.TryParse(Console.ReadLine(), out var tile);
                if (isContinue)
                {
                    game.Press(tile);
                }
            }
        }

        private static IEnumerable<ITile> BuildTiles(int tilesCount)
        {
            for (int i = 0; i < tilesCount; i++)
            {
                yield return new Tile(false);
            }
        }
    }
}
