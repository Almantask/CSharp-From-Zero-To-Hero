using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            string name = null;
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

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            bool isLossCalculate = false;
            string name = null;
            double diffBalance = 0;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double maxBalance = double.Parse(tempArray[1]);
                double minBalance = maxBalance;

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
                    return "N/A.";
                }

            }
            StringBuilder sb = new StringBuilder();
            name = FormarName(sb, name);
            return $"{name} lost the most money. -¤{diffBalance}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            string name = null;
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

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            string name = null;
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
    }
}