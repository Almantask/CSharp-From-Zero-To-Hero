using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Running;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
        }

        public static void DemoStringConcat()
        {
            var sw = new Stopwatch();
            sw.Start();
            var sb = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                sb.Append("TESTING STRING ");
            }

            sw.Stop();
            var elapsed1 = sw.ElapsedMilliseconds; // 5ms

            sw.Reset();

            sw.Start();
            var s = "";
            for (var i = 0; i < 100000; i++)
            {
                s += "TESTING STRING ";
            }
            sw.Stop();
            var elapsed2 = sw.ElapsedMilliseconds; // 32765 ms

            Console.WriteLine($"StringBuilder took {elapsed1}ms, String took {elapsed2}ms.");
        }

        public static void DemoSubstring()
        {
            var word = "Hello world!";

            string result;
            result = word.Substring(6); // world!
            Console.WriteLine($"word.Substring(6)={result}");
            result = word.Substring(0, 5); // Hello
            Console.WriteLine($"word.Substring(0, 5)={result}");
            result = word[..5]; // Hello
            Console.WriteLine($"word[..5]={result}");
            result = word[6..]; // world! 
            Console.WriteLine($"word[6..]={result}");
            result = word[..^1]; // Hello world
            // the same as word.Length -1 == ^1
            Console.WriteLine($"word[..^1]={result}");
            result = word[^1..]; // !
            Console.WriteLine($"word[^1..]={result}");
            // ello World!
            Console.WriteLine($"word[1..^1]={word[1..^1]}");

            var numbers = new[] {1, 2, 3};
            var lessNumbers = numbers[..^1];
        }
        public static void DemoStringCompare()
        {
            // sort people's names in alphabetical order

            var a = "a";
            var b = "b";

            var aToB = a.CompareTo(b); // -1
            if (aToB == -1)
            {
                Console.WriteLine("a < b");
            }
            var bToA = b.CompareTo(a); // 1
            if (bToA == 1)
            {
                Console.WriteLine("b > a");
            }

            const string A = "A";
            var aToA = a.CompareTo(A); // 0
            if (aToA == 0)
            {
                Console.WriteLine("a == A");
            }

            const string name1 = "Kaisinel";
            const string name2 = "Julian";
            var name1ToName2 = name1.CompareTo(name2); // 0

            const string smile = "😀";
            const string laughing = "😁";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Compare(smile, laughing);

            Compare("cc", "ccc");
        }
        private static void Compare(string word1, string word2)
        {
            var word1ToWord2 = word1.CompareTo(word2);
            switch (word1ToWord2)
            {
                case -1:
                    Console.WriteLine($"{word1} < {word2}");
                    break;
                case 0:
                    Console.WriteLine($"{word1} == {word2}");
                    break;
                case 1:
                    Console.WriteLine($"{word1} > {word2}");
                    break;
            }
        }
        public static void DemoJoinReplace()
        {
            var arr = new[] { "Bill", "Tom", "Jenkins", "Ada" };
            //arr.Join()// - not the way to do it.
            var joined = string.Join(',', arr); // Bill,Tom,Jenkins,Ada
            Console.WriteLine($"string.Join(',', arr)={joined}");
            joined = joined.Replace(",", ", "); // Bill, Tom, Jenkins, Ada
            Console.WriteLine($"joined.Replace(\",\", \", \")={joined}");
            arr = joined.Split(", "); // { "Bill", "Tom", "Jenkins", "Ada" }
            Console.WriteLine($"joined.Split(\", \")={joined}");
            joined = $"People's names: {joined}."; // People's names: Bill, Tom, Jenkins, Ada.
            Console.WriteLine(joined);
        }
        public static void DemoFormatting()
        {
            const string name = "Tom";
            const string profession = "Firefighter";
            var sentence = "This person is " + name + ", his profession is " + profession;
            var sentence2 = $"This person is {name, -20}, his profession is {profession, 20}.";
            var sentence3 = string.Format("This person is {0,-20}, his profession is {1, 20}.", name, profession);
            Console.WriteLine(sentence);
            Console.WriteLine(sentence2);
            Console.WriteLine(sentence3);



            // float
            // . vs ,nl-NL  en-IN  Invariant
            var a = 1;
            var b = 12345.1230;
            string wordF, wordN, wordC, wordP;

            CultureInfo.CurrentCulture = new CultureInfo("nl-NL");
            wordF = $"{b:F5}"; // 12345,12300
            wordN = $"{b:N5}"; // 12.345,12300
            wordC = $"{b:C5}"; // € 12.345,1230
            wordP = $"{b:P5}"; // 1.234.512.30000%
            var scientific = $"{b:E2}"; // 1,23E+004

            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            wordF = $"{b:F5}"; // 12345.12300
            wordN = $"{b:N5}"; // 12,345.12300
            wordC = $"{b:C5}"; // £12,345.12300
            wordP = $"{b:P5}"; // 1,234,512.300000%

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            wordF = $"{b:F5}"; // 12345.12300
            wordN = $"{b:N5}"; // 12,345.12300
            wordC = $"{b:C5}"; // ¤12,345.12300 //¤- means unspecified currency.
            wordP = $"{b:P5}"; // 1,234,512.30000 %

            // 00001
            var wordD = $"{a:D5}"; // 00001 
            var word0 = $"{a:00000}"; // 00001

            var paddLeft = name.PadLeft(5); // "  Tom"
            var padRight = name.PadRight(5); // "Tom  "
            var original = padRight.Trim();
        }
        public static void DemoParsing()
        {
            var numericString = "11";
            var word = "abv";

            var resultParse = int.Parse("1"); // 1. If failed, throws exception
            var isSuccess = int.TryParse(word, out resultParse); // // returns true, resultParse = 1. If failed returns false.

            var resultConvertNumber = Convert.ToInt32(numericString); // 11
            var resultConvertWord = Convert.ToInt32(word);
        }
        public static void DemoStringEquality()
        {
            string a1 = "a";
            string a2 = "a";
            object a3 = (object)"a";
            object a4 = (object)"a";

            bool result;

            //a1 == a2
            result = a1 == a2; // true 
            result = a1.Equals(a2); // true
            result = a1 == "a"; // true
            result = a4 == a3; // false, because references don't match.

            a1 = null;
            result = a1 == a2; // false
            result = string.Equals(a1, a2); // false
            result = a1.Equals(a2); // error
        }
    }
}
