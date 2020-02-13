namespace BootCamp.Chapter
{
    class Lesson7
    {
        /// <summary>
        /// Takes an array of floats and returns the highest value.
        /// </summary>
        /// <param name="array">Array of floats.</param>
        /// <returns>Highest float in the array.</returns>
        public static float MaxFloat(float[] array)
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
        /// Takes an array of floats and returns the lowest value.
        /// </summary>
        /// <param name="array">Array of floats.</param>
        /// <returns>Lowest float in the array.</returns>
        public static float MinFloat(float[] array)
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
                float parsed;
                if (float.TryParse(array[i], out parsed))
                {
                    returnArray[i] = parsed;
                }
                else
                {
                    returnArray[i] = 0f;
                }
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

    }
}
