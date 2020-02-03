using System;
using System.Text;

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
        public const string topAndBottomBorder = "-";
        public const string corner = "+";
        public const string space = " ";
        public const string sideBorder = "|";

        public static string Build(string message, int padding)
        {

            if (message == "")
            {
                return "";
            }
            int stringLength;
            var messageArray = (message.Contains(Environment.NewLine)) ? message.Split(Environment.NewLine) : null;

            if (messageArray != null)
            {
                stringLength = messageArray[0].Length > messageArray[1].Length ? messageArray[0].Length : messageArray[1].Length;
                for (int i = 0; i < messageArray.Length; i++)
                {
                    messageArray[i] = messageArray[i].Length < stringLength ? messageArray[i].PadRight(stringLength) : messageArray[i];
                }
            }
            else
            {

                stringLength = message.Length;
            }
            var sb = new StringBuilder();
            sb.Append(PrintTopOrBottomBorder(padding, stringLength));
            sb.Append($"{Environment.NewLine}");
            for (int i = 0; i < padding; i++)
            {
                sb.Append(PrintVerticalPaddingRow(padding, stringLength));
                sb.Append($"{Environment.NewLine}");
            }
            if (messageArray!=null)
            {
                for (int i = 0; i < messageArray.Length; i++)
                {
                    sb.Append(PrintMessageInTable(messageArray[0], padding));
                    sb.Append($"{Environment.NewLine}");
                }
            }
            else
            {
                sb.Append(PrintMessageInTable(message, padding));
            }
            sb.Append($"{Environment.NewLine}");
            for (int i = 0; i < padding; i++)
            {
                sb.Append(PrintVerticalPaddingRow(padding, stringLength));
                sb.Append($"{Environment.NewLine}");
            }
            sb.Append(PrintTopOrBottomBorder(padding, stringLength));
            sb.Append($"{Environment.NewLine}");

            string result = sb.ToString();
            return result;
            }


        
    

        public static string PrintVerticalPaddingRow(int padding, int stringLength)
        {
            var sb = new StringBuilder();
            sb.Append(sideBorder);
            for (int i = 0; i < padding * 2 + stringLength; i++)
            {
                sb.Append(space);
            }
            sb.Append(sideBorder);
            string verticalPaddingRow = sb.ToString();
            Console.WriteLine(verticalPaddingRow);
            return verticalPaddingRow;
        }
        public static string PrintMessageInTable(string message, int padding)
        {
            var sb = new StringBuilder();
            sb.Append(sideBorder);
            for (int i = 0; i < padding; i++)
            {
                sb.Append(space);
            }
            sb.Append(message.PadLeft(padding));
            message.PadLeft(padding);
            for (int i = 0; i < padding; i++)
            {
                sb.Append(space);
            }
            sb.Append(sideBorder);


            string messageInTable = sb.ToString();
            Console.WriteLine(messageInTable);
            return messageInTable;
        }
        public static string PrintTopOrBottomBorder(int padding, int stringLength)
        {
            var sb = new StringBuilder();
            sb.Append(corner);
            for (int i = 0; i < padding * 2 + stringLength; i++)
            {
                sb.Append(topAndBottomBorder);
            }
            sb.Append(corner);
            string topOrBottomLine = sb.ToString();
            Console.WriteLine(topOrBottomLine);
            return topOrBottomLine;
        }

    }
}
        /*
                   private static string[] _words;
        private static string _wordsString;

        static StringBenchmarks()
        {
            _words = new string[1000000];
            for (var i = 0; i < 1000000; i++)
            {
                _words[i] = "Hello";
            }

            _wordsString = string.Join(',', _words);
        }

        [Benchmark]
        public string SbConcatBench1() => SbConcat(1);

        [Benchmark]
        public string StringConcatBench1() => StringConcat(1);

        [Benchmark]
        public string SbConcatBench10() => SbConcat(10);

        [Benchmark]
        public string StringConcatBench10() => StringConcat(10);

        [Benchmark]
        public string SbConcatBench100() => SbConcat(100);

        [Benchmark]
        public string StringConcatBench100() => StringConcat(100);

        [Benchmark]
        public string SbConcatBench1000() => SbConcat(1000);

        [Benchmark]
        public string StringConcatBench1000() => StringConcat(1000);

        [Benchmark]
        public string SbJoinBench() => SbJoin();

        [Benchmark]
        public string StringJoinBench() => StringJoin();

        [Benchmark]
        public string SbReplaceBench() => SbReplace();

        [Benchmark]
        public string StringReplaceBench() => StringReplace();

        public static string StringConcat(long number)
        {
            var result = "";
            string.Join(",", result);
            for (var i = 0; i < number; i++)
            {
                result += "Hello";
            }

            return result;
        }

        public static string SbConcat(long number)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < number; i++)
            {
                sb.Append("Hello");
            }

            return sb.ToString();
        }

        public static string SbJoin()
        {
            var sb = new StringBuilder();
            var res = sb.AppendJoin(',', _words).ToString();

            return res;
        }

        public static string SbReplace()
        {
            var sb = new StringBuilder();
            var res = sb.Replace('H', 'B').ToString();

            return res;
        }

        public static string StringJoin() => string.Join(',', _words);

        public static string StringReplace() => _wordsString.Replace('H', 'B');


    }
}

        }
    }
}
*/
            //return "";
 