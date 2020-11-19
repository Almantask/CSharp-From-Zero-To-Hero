using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        const string negative = "N/A.";
        private static string name;

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return negative;
            }

            double current = double.MaxValue;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double tempResult;
                int num = tempArray.Length - 1;
                if (int.TryParse(tempArray[num], out int output))
                {
                    tempResult = output;
                }
                else if (tempArray[num] == string.Empty)
                {
                    tempResult = 0;
                }
                else
                {
                    tempResult = double.Parse(tempArray[num]);
                }

                if (tempResult - current < 0)
                {
                    current = tempResult;
                    name = tempArray[0];
                }
                else if (tempResult == current)
                {
                    name += " " + tempArray[0];
                }
            }
            StringBuilder sb = new StringBuilder();
            name = FormarName(sb, name);
            string finalOutput;
            if (current < 0)
                finalOutput = $"{name} has the least money. -¤{-current}.";
            else
                finalOutput = $"{name} has the least money. ¤{current}.";
            if (name.Contains("and"))
            {
                return finalOutput.Replace("has", "have");
            }
            return finalOutput;
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return negative;
            }

            double current = double.MinValue;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double tempResult;
                int num = tempArray.Length - 1;
                if (int.TryParse(tempArray[num], out int output))
                {
                    tempResult = output;
                }
                else if (tempArray[num] == string.Empty)
                {
                    tempResult = 0;
                }
                else
                {
                    tempResult = double.Parse(tempArray[num]);
                }

                if (tempResult - current > 0)
                {
                    current = tempResult;
                    name = tempArray[0];
                }
                else if (tempResult == current)
                {
                    name += " " + tempArray[0];
                }
            }
            StringBuilder sb = new StringBuilder();
            name = FormarName(sb, name);
            if (name.Contains("and"))
                return $"{name} are the richest people. ¤{current}.";
            else
                return $"{name} is the richest person. ¤{current}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return negative;
            }

            double diffBalance = 0;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double maxBalance = double.Parse(tempArray[1]);
                double minBalance = maxBalance;


                bool isLossCalculate;
                if (tempArray.Length <= 2)
                    isLossCalculate = false;
                else
                    isLossCalculate = true;

                for (int j = 1; j < tempArray.Length; j++)
                {
                    double tempResult;
                    if (int.TryParse(tempArray[j], out int output))
                    {
                        tempResult = output;
                    }
                    else if (tempArray[j] == string.Empty)
                    {
                        tempResult = 0;
                    }
                    else
                    {
                        tempResult = double.Parse(tempArray[j]);
                    }

                    if (tempResult - maxBalance > 0)
                    {
                        maxBalance = tempResult;
                    }
                    else if (tempResult - minBalance < 0)
                    {
                        minBalance = tempResult;
                    }
                }

                if (isLossCalculate)
                {
                    if (maxBalance - minBalance > diffBalance)
                    {
                        diffBalance = maxBalance - minBalance;
                        name = tempArray[0];
                    }
                    else if (maxBalance - minBalance == diffBalance)
                    {
                        name += " " + tempArray[0];
                    }
                }
                else
                {
                    return negative;
                }
            }
            StringBuilder sb = new StringBuilder();
            name = FormarName(sb, name);
            return $"{name} lost the most money. -¤{diffBalance}.";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return negative;
            }

            double maxBalance = 0;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double tempBalance = 0;
                for (int j = 1; j < tempArray.Length; j++)
                {
                    double tempResult;
                    if (int.TryParse(tempArray[j], out int output))
                    {
                        tempResult = output;
                    }
                    else if (tempArray[j] == string.Empty)
                    {
                        tempResult = 0;
                    }
                    else
                    {
                        tempResult = double.Parse(tempArray[j]);
                    }
                    if (tempResult - tempBalance > 0)
                    {
                        tempBalance = tempResult;
                    }

                }
                if (tempBalance - maxBalance > 0)
                {
                    maxBalance = tempBalance;
                    name = tempArray[0];
                }
                else if (tempBalance == maxBalance)
                {
                    name += " " + tempArray[0];
                }
            }
            StringBuilder sb = new StringBuilder();
            name = FormarName(sb, name);
            return $"{name} had the most money ever. ¤{maxBalance}.";
        }

        public static string FormarName(StringBuilder sb, string nameList)
        {
            string[] name = nameList.Split(" ");
            int num = name.Length;
            if (num == 1)
            {
                sb.Append(name[0]);
                return sb.ToString();
            }
            else if (num == 2)
            {
                sb.Append(name[0]);
                sb.Append(" and ");
                sb.Append(name[1]);
                return sb.ToString();
            }
            else
            {
                sb.AppendJoin(", ", name);
                string temp = sb.ToString();
                int index = temp.LastIndexOf(", ");
                string final = temp.Substring(0, index) + " and " + temp.Substring(index + 2);
                return final;
            }

        }

        public static string Build(string message, in int padding)  // to do some review
        {
            if (message == string.Empty)
            {
                return string.Empty;
            }

            int totalLength = 0;
            bool isMultiLineInput = message.Contains(Environment.NewLine);
            string[] newMessage;
            if (isMultiLineInput)
            {
                newMessage = message.Split(Environment.NewLine);
                for (int i = 0; i < newMessage.Length; i++)
                {
                    if (totalLength < newMessage[i].Length)
                        totalLength = newMessage[i].Length;
                }
                totalLength += padding * 2;
            }
            else
            {
                char[] input = message.ToCharArray();
                totalLength = input.Length + padding * 2;
            }

            //first line in output
            string top = Bottom(totalLength);
            WriteLine();
            // upper part
            string upper = Padding(padding, totalLength);
            // middle output
            string middle = null;
            if (isMultiLineInput)
            {
                newMessage = message.Split(Environment.NewLine);
                for (int i = 0; i < newMessage.Length; i++)
                {
                    string newPaddingLeft = newMessage[i].PadLeft(newMessage[i].Length + padding);
                    string newPaddingRight = newPaddingLeft.PadRight(totalLength);
                    middle += "|" + newPaddingRight + "|";
                    middle += $"{ Environment.NewLine}";
                }
            }
            else
            {
                string paddingLeft = message.PadLeft(totalLength - padding);
                string paddingRight = paddingLeft.PadRight(totalLength);
                middle += "|" + paddingRight + "|";
                middle += $"{Environment.NewLine}";
            }
            //lower part
            string lower = Padding(padding, totalLength);
            //bottom line
            string bottom = Bottom(totalLength);

            if (padding > 0)
                return top + upper + middle + lower + bottom;
            else
                return top + middle + bottom;
        }

        public static void Clean(string file, string outputFile)
        {
            try
            {
                if (string.IsNullOrEmpty(file) || string.IsNullOrEmpty(outputFile))
                {
                    throw new ArgumentException();
                }
                string fileExtension = Path.GetExtension(file);

                if (fileExtension.Contains("clean") || fileExtension.Contains("empty"))
                {
                    File.Copy(file, outputFile);
                    Console.WriteLine(" The file has no corruption - there is nothing to clean up.");
                    return;
                }

                using (StreamReader sr = new StreamReader(file))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        string raw = sr.ReadLine();
                        string preProcess = raw.Replace("_", "");
                        string[] balance = preProcess.Split(",");
                        ValidatePerson(balance);

                        sb.AppendLine(preProcess);
                    }
                    string output = sb.ToString().TrimEnd();
                    File.AppendAllText(outputFile, output);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        private static void ValidatePerson(string[] data)
        {
            string name = data[0];
            foreach (char c in data[0])
            {
                if (Char.IsDigit(c) || c == '.')
                {
                    throw new InvalidBalancesException($"{nameof(name)} is invalid ");
                }
            }
            if (data.Length > 1)
            {
                for (int i = 1; i < data.Length; i++)
                {
                    string temp = data[i].Replace("£", "");  //remove currency symbol
                    var isNumber = double.TryParse(temp, out _);
                    if (!isNumber)
                    {
                        throw new InvalidBalancesException($"{data[i]} is not a number ");
                    }
                }
            }


        }
        private static string Bottom(int length)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("+");
            for (int i = 0; i < length; i++)
            {
                sb.Append("-");
            }
            sb.Append("+");
            return $"{sb}{Environment.NewLine}";
        }
        private static string Padding(int padding, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < padding; i++)
            {
                sb.Append("|");
                for (int j = 0; j < length; j++)
                {
                    sb.Append(" ");
                }
                sb.Append("|");
            }
            return $"{sb}{Environment.NewLine}";
        }

    }
}
