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
                NewArr = ArrayOperations.ConvertStringArrtoDouble(arr);
                HighestBalance = 0;

                foreach (double balance in NewArr)
                {
                    if (balance > HighestBalance) { HighestBalance = balance; }
                }
                sr.Append(name + " " + Convert.ToString(HighestBalance)+" ");             
            }
            return ArrayOperations.ExtractNumbers(sr);

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
                NewArr = ArrayOperations.ConvertStringArrtoDouble(arr);
                if (NewArr.Length == 2)
                {
                    return "N/A.";
                }
                if(NewArr[NewArr.Length-1] == 0 || NewArr[NewArr.Length - 1] == -1)
                {
                    for(int i = 0; i < NewArr.Length-1;i++)
                    {
                        BigLost += NewArr[i]; 
                    }
                    
                    return name + " lost the most money. " + "-¤" + BigLost+".";
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
                NewArr = ArrayOperations.ConvertStringArrtoDouble(arr);
                Sold = NewArr[NewArr.Length - 1];
                
                if(Sold > HighestSold)
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
            return Convert.ToString(srName) + " is the richest person. ¤" + HighestSold+".";
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
                NewArr = ArrayOperations.ConvertStringArrtoDouble(arr);
                Balance = NewArr[NewArr.Length - 1];
                if(Balance < LowestBalance)
                {
                    srName.Clear();
                    srName.Append(name);
                    LowestBalance = Balance;
                    compter++;
                    clear++;
                }
                else if(Balance == LowestBalance)
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
            if(compter > 1 && clear == 1) return Convert.ToString(srName) + " have the least money. ¤" + LowestBalance + ".";
            if(LowestBalance == -1)  return Convert.ToString(srName) + " has the least money. -¤1."; 
            return Convert.ToString(srName)+ " has the least money. ¤"+LowestBalance+".";

        }

    }
}
