using System;

namespace BootCamp.Chapter1
{
	public static class ArrayOperations
	{
		/// <summary>
		/// Sort the array in ascending order.
		/// If array empty or null- don't do anything.
		/// </summary>
		/// <param name="array">Input array in a random order.</param>
		public static void Sort(int[] array)
		{
			//Return if null or empty
			if (array == null || array.Length == 0)
			{
				return;
			}

			//Bubble sort
			bool swapped;
			int holder;

			do
			{
				swapped = false;
				for (int i = 0; i < array.Length - 1; i++)
				{
					//Compare current and next item and swap if needed
					if (array[i] > array[i+1])
					{
						swapped = true;
						holder = array[i];
						array[i] = array[i+1];
						array[i+1] = holder;
					}
				}
			} while (swapped);
		}

		/// <summary>
		/// Reverse the array elements, first being last and so on.
		/// If array empty or null- don't do anything.
		/// </summary>
		/// <param name="array">Input array in a random order.</param>
		public static void Reverse(int[] array)
		{
			//Return if null or empty
			if (array == null || array.Length == 0)
			{
				return;
			}

			int holder;

			//Double index and swap front with back
			for (int front = 0, back = array.Length - 1; front < array.Length / 2; front++, back--)
			{
				holder = array[front];
				array[front] = array[back];
				array[back] = holder;
			}
		}

		/// <summary>
		/// Remove last element in array.
		/// </summary>
		/// <param name="array">Input array.</param>
		/// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
		public static int[] RemoveLast(int[] array)
		{
			//Return if null or empty
			if (array == null || array.Length == 0)
			{
				return array;
			}

			int[] result = new int[array.Length - 1];

			//Fill result array with all but last element
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = array[i];
			}

			return result;
		}

		/// <summary>
		/// Remove first element in array.
		/// </summary>
		/// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
		public static int[] RemoveFirst(int[] array)
		{
			//Return if null or empty
			if (array == null || array.Length == 0)
			{
				return array;
			}

			int[] result = new int[array.Length - 1];

			//Fill result array starting at index 0 with input array starting at index 1
			for (int i = 1; i < array.Length; i++)
			{
				result[i - 1] = array[i];
			}

			return result;
		}

		/// <summary>
		/// Removes array element at given index.
		/// </summary>
		/// <param name="array">Input array.</param>
		/// <param name="index">Index at which array element should be removed.</param>
		/// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
		public static int[] RemoveAt(int[] array, int index)
		{
			//Return if null or empty
			if (array == null || array.Length == 0)
			{
				return array;
			}

			//Return if index is out of bounds
			if (index < 0 || index >= array.Length)
			{
				return array;
			}

			int[] result = new int[array.Length - 1];
			int resultIndex = 0;

			//Fill result array excluding specified index
			for (int origIndex = 0; origIndex < array.Length; origIndex++)
			{
				//Skip specified index
				if (origIndex == index)
				{
					continue;
				}

				//Set value and increment the result index
				result[resultIndex++] = array[origIndex];
			}

			return result;
		}

		/// <summary>
		/// Inserts a new array element at the start.
		/// </summary>
		/// <param name="array">Input array.</param>
		/// <param name="number">Number to be added.</param>
		/// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
		public static int[] InsertFirst(int[] array, int number)
		{
			//Return {number} if null or empty
			if (array == null || array.Length == 0)
			{
				return new int[] { number };
			}

			int[] result = new int[array.Length + 1];
			int origIndex = 0;

			//Insert new number to the beginning
			result[0] = number;

			//Fill the rest of the result array
			for (int resultIndex = 1; resultIndex < result.Length; resultIndex++)
			{
				//Set value and increment the original index
				result[resultIndex] = array[origIndex++];
			}

			return result;
		}

		/// <summary>
		/// Inserts a new array element at the end.
		/// </summary>
		/// <param name="array">Input array.</param>
		/// <param name="number">Number to be added.</param>
		/// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
		public static int[] InsertLast(int[] array, int number)
		{
			//Return {number} if null or empty
			if (array == null || array.Length == 0)
			{
				return new int[] { number };
			}

			int[] result = new int[array.Length + 1];

			//Fill the result array
			for (int i = 0; i < array.Length; i++)
			{
				//Set value
				result[i] = array[i];
			}

			//Insert new number to the end
			result[result.Length - 1] = number;

			return result;
		}

		/// <summary>
		/// Inserts a new array element at the specified index.
		/// </summary>
		/// <param name="array">Input array.</param>
		/// <param name="number">Number to be added.</param>
		/// <param name="index">Index at which array element should be added.</param>
		/// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
		public static int[] InsertAt(int[] array, int number, int index)
		{
			//Return if index is out of bounds
			if (index < 0 || index > (array == null ? 0 : array.Length))
			{
				return array;
			}

			//Return {number} if null or empty
			if (array == null || array.Length == 0)
			{
				return new int[] { number };
			}

			int[] result = new int[array.Length + 1];
			int origIndex = 0;

			//Fill result array including specified index
			for (int resultIndex = 0; resultIndex < result.Length; resultIndex++)
			{
				//Insert at specified index
				if (resultIndex == index)
				{
					result[resultIndex] = number;
					continue;
				}

				//Set value and increment the original index
				result[resultIndex] = array[origIndex++];
			}

			return result;
		}
	}
}
