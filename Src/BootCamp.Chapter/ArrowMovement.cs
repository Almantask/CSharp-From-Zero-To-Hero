using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ArrowMovement
    {
		const char UP_ARROW = '↥';
		const char LEFT_ARROW = '↤';
		const char DOWN_ARROW = '↧';
		const char RIGHT_ARROW = '↦';

		/// <summary>
		/// Use your WASD (both capital and non capital) keys to print arrows  
		/// W- ↥  
		/// A- ↤  
		/// S- ↧  
		/// D- ↦
		/// Not case sensitive.
		/// </summary>
		/// <param name="symbol">Either of WASD character.</param>
		/// <returns>One of the arrow characters. '↥' by default.</returns>
		public static char GetIndicator(char symbol)
        {
			switch (char.ToUpper(symbol))
			{
				case 'A':
					return LEFT_ARROW;
				case 'S':
					return DOWN_ARROW;
				case 'D':
					return RIGHT_ARROW;
				default:
					return UP_ARROW;//Don't need a W case since it's the same return as the default
			}
        }
    }
}
