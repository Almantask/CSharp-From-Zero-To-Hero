using System;

namespace BootCamp.Chapter.Observer
{
    public class InvalidGameSetupException : Exception
    {
        public InvalidGameSetupException(int tileIndex) : base($"Tile at given index was not found. Index: {tileIndex}")
        {
        }
    }
}
