using System;

namespace BootCamp.Chapter
{
    class Lesson8
    {
        /// <summary>
        /// Takes an array of floats and returns the highest value.
        /// </summary>
        /// <param name="array">Array of floats.</param>
        /// <returns>Highest float in the array.</returns>
        public static float Max(float[] array)
        {
            float highestAsFar = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                float currentFloat = array[i];
                if (highestAsFar < currentFloat)
                {
                    highestAsFar = currentFloat;
                }
            }

            return highestAsFar;
        }

        /// <summary>
        /// Returns the lenght of the longest string in an array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int MaxLength(string[] array)
        {
            int currentMax = 0;
            foreach (string item in array)
            {
                if (item.Length > currentMax)
                {
                    currentMax = item.Length;
                }
            }
            return currentMax;
        }


        /// <summary>
        /// Takes an array of floats and returns the lowest value.
        /// </summary>
        /// <param name="array">Array of floats.</param>
        /// <returns>Lowest float in the array.</returns>
        public static float Min(float[] array)
        {
            float lowestAsFar = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                float currentFloat = array[i];
                if (lowestAsFar > currentFloat)
                {
                    lowestAsFar = currentFloat;
                }
            }

            return lowestAsFar;
        }

        /// <summary>
        /// takes an array of strings and parses them all into floats
        /// </summary>
        /// <param name="array">array of strings</param>
        /// <returns>array of floats</returns>
        public static float[] StringArrayToFloatArray(string[] array)
        {
            var returnArray = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = float.TryParse(array[i], out float parsed) ? parsed : 0f;
            }

            return returnArray;
        }

        /// <summary>
        /// Returns an array of strings with the appended element at the end.
        /// </summary>
        /// <param name="array">Array to append to.</param>
        /// <param name="toAppend">Element to append to array.</param>
        /// <returns>New array.</returns>
        public static string[] AppendString(string[] array, string toAppend)
        {
            var returnArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = array[i];
            }
            returnArray[^1] = toAppend;
            return returnArray;
        }

        /// <summary>
        /// Takes an array of strings and joins them by comma and "and" for the last one
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string FormatArrayToString(string[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            var returnString = string.Join(", ", array[..^1]);
            returnString += $" and {array[^1]}";
            return returnString;
        }

        /// <summary>
        /// Check if two floats are equal by comparing the distance between them to float.Epsilon
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static bool EqualFloats(float number1, float number2)
        {
            return Math.Abs(number1 - number2) < float.Epsilon;
        }
    }
}
