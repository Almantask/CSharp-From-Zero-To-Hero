using System;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            if (message == "")
            {
                return "";
            }

            var arr = message.Split($"{Environment.NewLine}");
            int longerLineSize = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > longerLineSize)
                {
                    longerLineSize = arr[i].Length;
                }
            }

            var frame = new string[arr.Length + 2 + padding * 2];

            //top and bottom lines
            frame[0] = "+";
            for (var i = 0; i < longerLineSize + padding * 2; i++)
            {
                frame[0] += "-";
            }
            frame[0] += "+";
            frame[frame.Length - 1] = $"{Environment.NewLine}{frame[0]}{Environment.NewLine}";

            //padding lines
            string paddingLine = $"{Environment.NewLine}|";
            for (int j = 0; j < longerLineSize + padding * 2; j++)
            {
                paddingLine += " ";
            }
            paddingLine += "|";

            for (var i = 0; i < padding; i++)
            {
                frame[i + 1] = paddingLine;
                frame[frame.Length - 2 - i] = paddingLine;
            }


            //boddy
            for (var i = 0; i < arr.Length; i++)
            {
                //begining of each text line
                frame[i + 1 + padding] = $"{Environment.NewLine}|";
                //add padding
                for (int j = 0; j < padding; j++)
                {
                    frame[i + 1 + padding] += " ";
                }
                //add text
                frame[i + 1 + padding] += arr[i];

                //ending and padding
                for (var k = 0; k < longerLineSize + padding - arr[i].Length; k++)
                {
                    frame[i + 1 + padding] += " ";
                }
                frame[i + 1 + padding] += "|";
            }

            return String.Join("", frame);
        }
    }
}
