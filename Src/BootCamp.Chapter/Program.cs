using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {


        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string corrupted = @"C:\Users\Pedro Win\Documents\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted";
            string cleaned = @"C:\Users\Pedro Win\Documents\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.cleaned";
            FileCleaner.Clean(corrupted, cleaned);
            var lines = File.ReadAllText(cleaned).Split("\r\n");

            var persons = ParseBalances(lines);

            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            Console.WriteLine(Frame(FindHighestBalanceEver(persons), 3));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(Frame(FindPersonWithBiggestLoss(persons), 3));
            // - FindRichestPerson
            Console.WriteLine(Frame(FindRichestPerson(persons), 3));
            // - FindMostPoorPerson
            Console.WriteLine(Frame(FindMostPoorPerson(persons), 3));
        }

        public static Person[] ParseBalances(string[] lines)
        {
            if(lines == null || lines.Length == 0) return null;
            var persons = new Person[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] slots = lines[i].Split(",");
                string name = slots[0];
                float[] balances = null;

                if (slots.Length > 1)
                {
                    balances = new float[slots.Length - 1];

                    for (int j = 1; j < slots.Length; j++)
                    {
                        float number;
                        bool isNumber = float.TryParse(slots[j], NumberStyles.Currency, CultureInfo.GetCultureInfo("en-GB"), out number);
                        balances[j - 1] = number;
                    }
                }


                persons[i] = new Person(name, balances);
            }

            return persons;
        }
        public static string FindHighestBalanceEver(Person[] persons)
        {
            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? highestPersonalBalance;
            float? highestBalance = null;
            string[] persosnsWithHighestBalance = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                highestPersonalBalance = persons[i].GetHighestBalance();

                if (highestBalance == null)
                {
                    highestBalance = highestPersonalBalance;
                    persosnsWithHighestBalance = new string[] { name };
                }
                else if (highestPersonalBalance == highestBalance)
                {
                    persosnsWithHighestBalance = AppendToStringArray(persosnsWithHighestBalance, name);
                }
                else if (highestPersonalBalance > highestBalance)
                {
                    persosnsWithHighestBalance = new[] { name };
                    highestBalance = highestPersonalBalance;
                }
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            return $"{ComposeListString(persosnsWithHighestBalance)} had the most money ever. {highestBalance:c0}.";
        }
        public static string FindPersonWithBiggestLoss(Person[] persons)
        {
            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? biggestPersonalLoss;
            float? biggestLoss = null;
            string[] persosnsWithBiggestLoss = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                biggestPersonalLoss = persons[i].GetBiggestLoss();

                if (biggestLoss == null)
                {
                    biggestLoss = biggestPersonalLoss;
                    persosnsWithBiggestLoss = new string[] { name };
                }
                else if (biggestPersonalLoss == biggestLoss)
                {
                    persosnsWithBiggestLoss = AppendToStringArray(persosnsWithBiggestLoss, name);
                }
                else if (biggestPersonalLoss < biggestLoss)
                {
                    persosnsWithBiggestLoss = new[] { name };
                    biggestLoss = biggestPersonalLoss;
                }
            }

            if (biggestLoss == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            return $"{ComposeListString(persosnsWithBiggestLoss)} lost the most money. {biggestLoss:c0}.";
        }
        public static string FindMostPoorPerson(Person[] persons)
        {
            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? lastBalance;
            float? lowestLastBalance = null;
            string[] persosnsWithLeastMoney = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                lastBalance = persons[i].GetLastBalance();

                if (lowestLastBalance == null)
                {
                    lowestLastBalance = lastBalance;
                    persosnsWithLeastMoney = new string[] { name };
                }
                else if (lastBalance == lowestLastBalance)
                {
                    persosnsWithLeastMoney = AppendToStringArray(persosnsWithLeastMoney, name);
                }
                else if (lastBalance < lowestLastBalance)
                {
                    persosnsWithLeastMoney = new[] { name };
                    lowestLastBalance = lastBalance;
                }
            }

            if (lowestLastBalance == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            if (persosnsWithLeastMoney.Length == 1)
            {
                return $"{ComposeListString(persosnsWithLeastMoney)} has the least money. {lowestLastBalance:c0}.";
            }
            else
            {
                return $"{ComposeListString(persosnsWithLeastMoney)} have the least money. {lowestLastBalance:c0}.";
            }
        }
        public static string FindRichestPerson(Person[] persons)
        {
            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? lastBalance;
            float? HighestLastBalance = null;
            string[] richestPersons = null;

            for (int i = 0; i < persons.Length; i++)
            {

                name = persons[i].GetName();
                lastBalance = persons[i].GetLastBalance();

                if (HighestLastBalance == null)
                {
                    HighestLastBalance = lastBalance;
                    richestPersons = new string[] { name };
                }
                else if (lastBalance == HighestLastBalance)
                {
                    richestPersons = AppendToStringArray(richestPersons, name);
                }
                else if (lastBalance > HighestLastBalance)
                {
                    richestPersons = new[] { name };
                    HighestLastBalance = lastBalance;
                }
            }

            if (HighestLastBalance == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            if (richestPersons.Length == 1)
            {
                return $"{ComposeListString(richestPersons)} is the richest person. {HighestLastBalance:c0}.";
            }
            else
            {
                return $"{ComposeListString(richestPersons)} are the richest people. {HighestLastBalance:c0}.";
            }
        }
        public static string Frame(string message, int padding)

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

        static string ComposeListString(string[] items)
        {
            if (items == null)
            {
                return "";
            }
            int length = items.Length;
            switch (length)
            {
                case 0:
                    return "";
                case 1:
                    return items[0];
                case 2:
                    return string.Join(" and ", items);
                default:
                    var firstsArr = new string[items.Length - 1];
                    for (int i = 0; i < firstsArr.Length; i++)
                    {
                        firstsArr[i] = items[i];
                    }

                    string firsts = string.Join(", ", firstsArr);
                    var last = $" and {items[^1]}";
                    return firsts + last;
            }
        }

        //static string ComposeListString(string[] items) //this is an optimization of my method that Bing chat sugested 
        //{
        //    if (items == null || items.Length == 0)
        //    {
        //        return "";
        //    }
        //    var sb = new StringBuilder();
        //    sb.AppendJoin(", ", items[..^1]); // append all items except the last one
        //    if (items.Length > 1)
        //    {
        //        sb.Append(" and "); // append the conjunction
        //    }
        //    sb.Append(items[items.Length - 1]); // append the last item
        //    return sb.ToString();
        //}

        static string[] AppendToStringArray(string[] items, string item)
        {
            string[] newArray = new string[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            newArray[^1] = item;
            return newArray;

        }

    }
}
