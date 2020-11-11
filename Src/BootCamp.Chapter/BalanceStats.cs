namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            string name = null, current = null;
            double maxBalance = 0;

            for(int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double tempBalance = 0;
                for(int j = 1; j < tempArray.Length; j++)
                {
                    double tempResult;
                    if (int.TryParse(tempArray[j], out int output))
                    {
                        tempResult = output;
                    }
                    else if(tempArray[j] == string.Empty)
                    {
                        tempResult = 0;
                    }
                    else 
                    {
                        tempResult = double.Parse(tempArray[j]);
                    }
                    if(tempResult - tempBalance > 0)
                    {
                        tempBalance = tempResult;
                    }
                    
                }
                if (tempBalance - maxBalance > 0)
                {
                    maxBalance = tempBalance;
                    name = tempArray[0];
                    current = tempArray[tempArray.Length - 1];
                }

            }
            return $"{name},{current}";
            
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string name = null;
            double diffBalance = 0; 

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] tempArray = peopleAndBalances[i].Split(", ");
                double maxBalance = 0, minBalance = 0;
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
                    else if(tempResult - minBalance < 0)
                    {
                        minBalance = tempResult;
                    }
                }
                
                if (maxBalance - minBalance > diffBalance)
                {
                    diffBalance = maxBalance - minBalance;
                    name = tempArray[0];
                }

            }
            return $"{name},{diffBalance}";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string name = null;
            double current = 0;

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

                if (tempResult - current> 0)
                {
                    current = tempResult;
                    name = tempArray[0];
                }
            }
            return $"{name},{current}";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            string name = null;
            double current = 1000000;

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
            }
            return $"{name},{current}";
        }
    }
}
