using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
	public static class BinaryConverter
	{
		public static long ToInteger(string binary)
		{
			//Return 0 if empty
			if (string.IsNullOrEmpty(binary))
			{
				return 0;
			}

			bool isBinary = binary.All(c => c == '1' || c == '0');

			//Throw error if not binary
			if (!isBinary)
			{
				throw new InvalidBinaryNumberException(binary);
			}

			//Set value to first binary digit
			long value = (binary[0] - '0');

			//Multiply value by 2 and then add each binary
			foreach (char c in binary[1..^0])
			{
				//Multiply current value by 2
				value *= 2;
				//Add current binary
				value += (c - '0');
			}

			return value;
		}

		public static string ToBinary(long number)
		{
			long currentValue = number;
			long remainder;
			List<int> reverseBinary = new List<int>();

			//Loop division till you hit 0 (do at least once if we start at 0 to have it store the value)
			do
			{
				//Divide and get result and remainder
				currentValue = Math.DivRem(currentValue, 2, out remainder);
				//Save remainder as binary
				reverseBinary.Add((int)remainder);
			} while (currentValue > 0);

			//Flip the list to put the bits in the right order
			reverseBinary.Reverse();

			return String.Join("", reverseBinary);
		}
	}
}
