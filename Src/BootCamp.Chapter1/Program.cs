using System;

namespace BootCamp.Chapter1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Example arrays to test
			int[] nullArray = null;
			int[] emptyArray = { };
			int[] forwardArray = {1, 2, 3, 4, 5};
			int[] reverseArray = {5, 4, 3, 2, 1};
			int[][] exampleArrays = new int[][]
			{
				nullArray, emptyArray, forwardArray, reverseArray
			};
			int givenArrayIndex = 2;
			int givenElement = 0;


			int[] editableArray = null;

			//1. Ascending sort
			Console.WriteLine("1. Sort array in ascending order");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				ArrayOperations.Sort(editableArray);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//2. Inverse sort
			Console.WriteLine("2. Inverse array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				ArrayOperations.Reverse(editableArray);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//3. Remove 1st element
			Console.WriteLine("3. Remove first element from array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.RemoveFirst(editableArray);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//4. Remove last element
			Console.WriteLine("4. Remove last element from array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.RemoveLast(editableArray);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//5. Remove indexed element
			Console.WriteLine("5. Remove element at a given index from array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.RemoveAt(editableArray, givenArrayIndex);

				//Print edited array
				Console.Write(ArrayToString(editableArray));

				if (editableArray == null || editableArray.Length == 0)
				{
					Console.WriteLine();
				}
				else
				{
					Console.WriteLine($" (index = {givenArrayIndex})");
				}
			}
			Console.WriteLine();

			//6. Insert element to start
			Console.WriteLine("6. Insert element at the start of array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.InsertFirst(editableArray, givenElement);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//7. Insert element to end
			Console.WriteLine("7. Insert element at the end of array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.InsertLast(editableArray, givenElement);

				//Print edited array
				Console.WriteLine(ArrayToString(editableArray));
			}
			Console.WriteLine();

			//8. Insert element at index
			Console.WriteLine("8. Insert element at specified index of array");

			foreach (int[] exampleArray in exampleArrays)
			{
				//Print original array
				Console.Write($"{ArrayToString(exampleArray)} -> ");

				//Create a copy to edit
				CopyArray(exampleArray, ref editableArray);

				//Edit array
				editableArray = ArrayOperations.InsertAt(editableArray, givenElement, givenArrayIndex);

				//Print edited array
				Console.Write(ArrayToString(editableArray));

				if (editableArray == null || editableArray.Length == 0)
				{
					Console.WriteLine();
				}
				else
				{
					Console.WriteLine($" (index = {givenArrayIndex})");
				}
			}
			Console.WriteLine();

			Console.ReadLine();
		}

		static void CopyArray(int[] source, ref int[] destination)
		{
			if (source == null)
			{
				destination = null;
			}
			else
			{
				destination = new int[source.Length];
				Array.Copy(source, destination, source.Length);
			}
		}

		static string ArrayToString(int[] array)
		{
			string result = "";

			//Set text for null/empty
			if (array == null)
			{
				result = "null";
			}
			else if (array.Length == 0)
			{
				result = "empty";
			}
			else//Build the string
			{
				result += $"{{ {array[0]}";
				for (int i = 1; i < array.Length; i++)
				{
					result += $", {array[i]}";
				}
				result += " }";
			}

			return result;
		}
	}
}
