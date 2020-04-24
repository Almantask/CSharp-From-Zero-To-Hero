using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileUtilities
    {
        //This class will implement functions for file validation, balance analysis, etc.
        //ToDo: Implement...
        public static string[] MakeContentParsable(string inputFilePath, string stringToReplace)
        {
            if (File.Exists(inputFilePath))
            {
                var inputLines = File.ReadAllLines(inputFilePath);
                var parsableLines = new string[inputLines.Length];

                for (int i = 0; i < inputLines.Length; i++)
                {
                    var parsableLine = inputLines[i].Replace(stringToReplace, "");
                    parsableLines[i] = parsableLine;
                }

                return parsableLines;
            }

            return new string[] { "" };
        }
    }
}
