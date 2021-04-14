using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            string[] list = File.ReadAllLines(dirtyFile);
            string[] NewList = { };
            StringBuilder sr = new StringBuilder();

            for (int i = 0; i < list.Length; i++)
            {
                NewList = list[i].Split(",");
                for (int j = 0; j < NewList.Length; j++)
                {
                    NewList[j] = CleanAndVerify(NewList[j]);
                    sr.Append(NewList[j] + ",");
                }
                sr.Remove(sr.Length - 1, 1);
                if (i != list.Length - 1) sr.AppendLine();
            } 

             File.WriteAllText(cleanedFile, sr.ToString());
           
        }

        static string CleanAndVerify(string Element)
        {
            string NewElement = "";           
            foreach (var item in Element)
            {
                if (item != '_') NewElement += item;
            }
            try
            {
                return Convert.ToString(NewElement);
            }
            catch (FormatException e)
            {
                throw new InvalidBalancesException(e.Message,e);
            }
        }
    }
}
