using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

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


            if (dirtyFile == null || cleanedFile == null) throw new ArgumentException();
            if (dirtyFile == "" || cleanedFile == "") throw new ArgumentException();
            if (!(File.Exists(dirtyFile))) throw new ArgumentException();


            StreamReader readFile = new StreamReader(dirtyFile);
            string line;
            StringBuilder cleanLines = new StringBuilder();

            while ((line = readFile.ReadLine()) != null)
            {
                CheckValid(line);
            }
            readFile.Dispose();

            string dirtyFileContents = File.ReadAllText(dirtyFile);
            var cleanedFileContents = dirtyFileContents.Replace("_", "");

            File.WriteAllText(cleanedFile, cleanedFileContents.ToString());

        }

        public static void CheckValid(string line)
        {

            line = line.Replace("_", "");
            var valid = Regex.Replace(line, @"[\p{Sc}]", "");
            string[] values = valid.Split(',');

            //check if the number is valid
            if (values.Length > 1)
            {
                for (var i = 1; i < values.Length; i++)
                {
                    try
                    {
                        float.Parse(values[i]);
                    }
                    catch (FormatException e)
                    {
                        throw new InvalidBalancesException("This is not a number", e);
                    }
                }
            }

            try
            {
                if (!Regex.IsMatch(values[0], @"^[a-zA-Z '-]+$"))
                    throw new FormatException();

            }
            catch (FormatException e)
            {
                throw new InvalidBalancesException("Name cannot contain Numbers", e);
            }


        }

        //returns file as an array with currency symbols removed. 
        public static string[] CleanFile(string fileName)
        {

            string[] result = File.ReadAllLines(fileName);

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = Regex.Replace(result[i], @"[\p{Sc}]", "");
            }


            return result;
        }


    }
}