using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class FilesUtility
    {
        private static readonly string rootPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        public static readonly string coruptedFile = rootPath + @"\Input\Balances.corrupted";
        public static readonly string repairedFile = rootPath + @"\Output\Balances.repaired";
        public static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };

        private const string coruption = "_";
        private const string splitByString = ",€";
        private const string newDivider = "|";
        private const string emptyString = "";
        private const string commaChar = ",";
        private const string dotChar = ".";

        /// <summary>
        /// The method is used to create parsable array for the main statistic methods.
        /// Returned array represents a repaired form of the corrupted balances.
        /// </summary>
        public static string[] MakeBalancesParsable()
        {
            string[] corruptedLines = default;
            try
            {
                corruptedLines = File.ReadAllLines(coruptedFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var repairedLines = new string[corruptedLines.Length];
            for (int i = 0; i < corruptedLines.Length; i++)
            {
                repairedLines[i] = corruptedLines[i]
                    .Replace(coruption, emptyString)
                    .Replace(splitByString, newDivider)
                    .Replace(commaChar, dotChar)
                    .Replace(newDivider, commaChar);
            }
            return repairedLines;
        }

        public static void RepairPeopleAndBalances(string coruptedFilePath, string repairedFilePath)
        {
            var sb = ReadCoruptFile(coruptedFilePath);
            WriteRepairedFile(repairedFilePath, sb);
            Console.WriteLine($"Corrupted file: {coruptedFilePath}");
            Console.WriteLine($"Repaired file: {repairedFilePath}");
        }

        /// <summary>
        /// Reads the contents of the corrupted file line by line and removes "_".
        /// Returns a StringBuilder constructor.
        /// </summary>
        /// <param name="coruptedFilePath">
        /// Corrupted balances file.
        /// </param>
        private static StringBuilder ReadCoruptFile(string coruptedFilePath)
        {
            string line;
            var sb = new StringBuilder();

            try
            {
                using (StreamReader reader = new StreamReader(coruptedFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        sb.Append(line).Replace(coruption, emptyString).Append(Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return sb;
        }

        /// <summary>
        /// Writes to a new file StringBuilder constructor received from ReadCorupteFile method.
        /// </summary>
        /// <param name="repairedFilePath">
        /// Ouput for repaired balances file.
        /// </param>
        /// <param name="sb">
        /// Input StringBuilder from ReadCorupteFile method.
        /// </param>
        private static void WriteRepairedFile(string repairedFilePath, StringBuilder sb)
        {
            try
            {
                if (File.Exists(repairedFilePath))
                {
                    try
                    {
                        File.Delete(repairedFilePath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                using (StreamWriter writer = new StreamWriter(repairedFilePath, true, Encoding.UTF8))
                {
                    writer.Write(sb);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}