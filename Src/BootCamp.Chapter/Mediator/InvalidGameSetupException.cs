using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Mediator
{
    public class InvalidGameSetupException : Exception
    {
        public InvalidGameSetupException(int tileIndex) : base($"Tile at given index was not found. Index: {tileIndex}")
        {
        }
    }
}
