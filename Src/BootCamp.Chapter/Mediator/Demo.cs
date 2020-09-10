using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Mediator
{
    public static class MediatorDemo
    {
        public static void Run()
        {
            var game = new ColorAllGame();
            var tiles = BuildTiles(5, game);
            game.SetTiles(tiles);

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

        private static IEnumerable<ITile> BuildTiles(int tilesCount, IColorAllGame game)
        {
            for (int i = 0; i < tilesCount; i++)
            {
                yield return new Tile(false, game);
            }
        }
    }
}
