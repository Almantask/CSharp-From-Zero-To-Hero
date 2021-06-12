using System;
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
            string name = " ";
            string[] arr;

            double[] NewArr;
            double HighestBalance = 0;
            StringBuilder sr = new StringBuilder();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            /*Loop that split an Array composed of string arrays , to finally keep just one array with
             names associated with the heighest balance value */
            foreach (string account in peopleAndBalances)
            {

                arr = account.Split(",");
                name = arr[0];
                Array.Clear(arr, 0, 1);
                NewArr = ConvertStringArrtoDouble(arr);
                HighestBalance = 0;

                foreach (double balance in NewArr)
                {
                    if (balance > HighestBalance) { HighestBalance = balance; }
                }
                sr.Append(name + " " + Convert.ToString(HighestBalance) + " ");
            }
            return ExtractNumbers(sr);

        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string name = " ";
            string[] arr;

            double BigLost = 0;
            double[] NewArr;

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string account in peopleAndBalances)
            {

                arr = account.Split(",");
                name = arr[0];
                Array.Clear(arr, 0, 1);
                NewArr = ConvertStringArrtoDouble(arr);
                if (NewArr.Length == 2)
                {
                    return "N/A.";
                }
                if (NewArr[NewArr.Length - 1] == 0 || NewArr[NewArr.Length - 1] == -1)
                {
                    for (int i = 0; i < NewArr.Length - 1; i++)
                    {
                        BigLost += NewArr[i];
                    }

                    return name + " lost the most money. " + "-¤" + BigLost + ".";
                }

            }
            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string name = " ";
            string[] arr;

            double[] NewArr;
            double Sold;
            double HighestSold = 0;
            int compter = 0;
            StringBuilder srName = new StringBuilder();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            foreach (string account in peopleAndBalances)
            {
                arr = account.Split(",");
                name = arr[0];
                Array.Clear(arr, 0, 1);
                NewArr = ConvertStringArrtoDouble(arr);
                Sold = NewArr[NewArr.Length - 1];

                if (Sold > HighestSold)
                {
                    compter++;
                    srName.Clear();
                    srName.Append(name);
                    HighestSold = Sold;
                }
                else if (Sold == HighestSold)
                {
                    if (compter == 0)
                    {
                        srName.Append(name);
                        compter++;
                    }
                    else if (compter == 1)
                    {
                        srName.Append(", " + name);
                        compter++;
                    }
                    else
                    {
                        srName.Append(" and " + name);
                    }

                }
            }
            if (compter > 1 && srName.Length > 4) return Convert.ToString(srName) + " are the richest people. ¤" + HighestSold + ".";
            return Convert.ToString(srName) + " is the richest person. ¤" + HighestSold + ".";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            string name = " ";
            string[] arr;

            double[] NewArr;
            double Balance;
            double LowestBalance = 10000;

            int compter = 0;
            int clear = 0;
            StringBuilder srName = new StringBuilder();

            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            /*Loop that split an Array composed of string arrays , to finally keep just one array with
             names associated with the heighest balance value */
            foreach (string account in peopleAndBalances)
            {
                arr = account.Split(",");
                name = arr[0];
                Array.Clear(arr, 0, 1);
                NewArr = ConvertStringArrtoDouble(arr);
                Balance = NewArr[NewArr.Length - 1];
                if (Balance < LowestBalance)
                {
                    srName.Clear();
                    srName.Append(name);
                    LowestBalance = Balance;
                    compter++;
                    clear++;
                }
                else if (Balance == LowestBalance)
                {
                    if (compter == 0)
                    {
                        srName.Append(name);
                        compter++;
                    }
                    else if (compter == 1)
                    {
                        srName.Append(", " + name);
                        compter++;
                    }
                    else
                    {
                        srName.Append(" and " + name);
                    }

                }
            }
            if (compter > 1 && clear == 1) return Convert.ToString(srName) + " have the least money. ¤" + LowestBalance + ".";
            if (LowestBalance == -1) return Convert.ToString(srName) + " has the least money. -¤1.";
            return Convert.ToString(srName) + " has the least money. ¤" + LowestBalance + ".";

        }

        //Methods that process Array Operations

        static bool EndsWithEmpty(String s)
        {
            if (s == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double[] ConvertStringArrtoDouble(string[] arr)
        {
            double[] newArr;
            newArr = Array.ConvertAll(arr, new Converter<string, double>(ConverttoDouble));

            static double ConverttoDouble(string element)
            {
                if (element == " ")
                {
                    return 0;
                }
                return Convert.ToDouble(element);
            }

            return newArr;
        }

        public static string ExtractNumbers(StringBuilder sr)
        {
            StringBuilder name = new StringBuilder();

            char n;
            string str = sr.ToString();
            string[] arr = str.Split(" ");

            int compter = 0;
            double balance = 0;
            double Heighestbalance = 0;

            /* newIndex solves the issue with the last item who s an empty string 
             this snippet allows us to remove the last item if it is an empty string
            */
            int Index = Array.FindLastIndex(arr, EndsWithEmpty);
            if (Index != -1)
            {
                Array.Resize(ref arr, Index);
            }

            //Loop that extract the heighest balance form the array
            for (int i = 0; i < arr.Length; i++)
            {
                bool test = Char.IsDigit(arr[i], 0);
                if (test == true)
                {
                    balance = Convert.ToDouble(arr[i]);
                    if (balance > Heighestbalance)
                    {
                        name.Clear();
                        name.Append(arr[i - 1]);
                        Heighestbalance = balance;
                    }
                    else if (balance == Heighestbalance)
                    {
                        if (compter == 0)
                        {
                            compter++;
                            name.Append(", " + arr[i - 1] + " and ");
                        }
                        else
                        {
                            name.Append(arr[i - 1]);
                        }

                    }
                }
            }

            return name + " had the most money ever. ¤" + Heighestbalance.ToString() + ".";

        }

    }
}