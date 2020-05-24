using System;
using System.Globalization;
using System.Linq;


namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal highestBalance = 0;
            Person[] peopleArray = GetPeopleArray(peopleAndBalances);
            string[] NameArray = new string[20];

            for (int i = 0; i < peopleArray.Length; i++)
            {
                if (peopleArray[i].Balance.Max() > highestBalance)
                {
                    highestBalance = peopleArray[i].Balance.Max();
                    ClearNameArray(NameArray);
                    AddName(peopleArray[i].Name, NameArray);
                }
                else if (peopleArray[i].Balance.Max() == highestBalance)
                {
                    AddName(peopleArray[i].Name, NameArray);
                }
            }

            return $"{FormatNameArray(NameArray)} had the most money ever. ¤{highestBalance.ToString()}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal biggestLoss = 0;
            string personWithBiggestLoss = null;
            bool enoughBalance = false;
            Person[] peopleArray = GetPeopleArray(peopleAndBalances);
            
            for (int i = 0; i < peopleArray.Length; i++)
            {
                int balanceSize = peopleAndBalances[i].Split().Length;

                if (peopleAndBalances[i].Split().Length >= 3)
                {
                    enoughBalance = true;
                }
                if (peopleArray[i].Balance[i+1] != 0)
                {
                    enoughBalance = true;
                }

                for (int j = 1; j < balanceSize -1; j++)
                {
                    if (peopleArray[i].Balance[j] == 0 && peopleArray[i].Balance[j+1] == 0 && balanceSize < 3 )
                        break;
                    
                    decimal currentLoss = peopleArray[i].Balance[j - 1] - peopleArray[i].Balance[j];
                    if (currentLoss > biggestLoss)
                    {
                        biggestLoss = currentLoss;
                        personWithBiggestLoss = peopleArray[i].Name;
                    }
                }
            }
            if (!enoughBalance)
                return "N/A.";

            return $"{personWithBiggestLoss} lost the most money. -¤{Math.Abs(biggestLoss)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal highestBalance = 0;
            Person[] peopleArray = GetPeopleArray(peopleAndBalances);

            string[] richestPersonArray = new string[20];

            for (int i = 0; i < peopleArray.Length; i++)
            {
                int balanceSize = peopleAndBalances[i].Split(',').Length - 1;
                if (peopleArray[i].Balance[balanceSize -1] > highestBalance)
                {
                    highestBalance = peopleArray[i].Balance[balanceSize -1];
                    ClearNameArray(richestPersonArray);
                    AddName(peopleArray[i].Name, richestPersonArray);
                }
                else if (peopleArray[i].Balance[balanceSize - 1] == highestBalance)
                {
                    AddName(peopleArray[i].Name, richestPersonArray);
                }
            }

            int richestArraySize = 0;
            for (int i = 0; i < richestPersonArray.Length; i++)
            {
                if (richestPersonArray[i+1] == "" || richestPersonArray[i+1] == null)
                {
                    richestArraySize = i + 1;
                    break;
                }
            } 
            return $"{FormatNameArray(richestPersonArray)} {(richestArraySize > 1 ? "are the richest people." : "is the richest person.")} ¤{highestBalance.ToString()}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";
            
            var peopleArray = GetPeopleArray(peopleAndBalances);
            int balanceSize = peopleAndBalances[0].Split(',').Length - 1;
            decimal lowerBalance = peopleArray[0].Balance[balanceSize - 1];
            string[] mostPoorPersonArray = new string[20];

            for (int i = 0; i < peopleArray.Length; i++)
            {
                int internalBalanceSize = peopleAndBalances[i].Split(',').Length - 1;

                if (peopleArray[i].Balance[internalBalanceSize -1] < lowerBalance)
                {
                    lowerBalance = peopleArray[i].Balance[internalBalanceSize - 1];
                    ClearNameArray(mostPoorPersonArray);
                    AddName(peopleArray[i].Name, mostPoorPersonArray);
                }
                else if (peopleArray[i].Balance[internalBalanceSize - 1] == lowerBalance)
                {
                    AddName(peopleArray[i].Name, mostPoorPersonArray);
                }
            }

            int mostPoorArraySize = 0;
            for (int i = 0; i < mostPoorPersonArray.Length; i++)
            {
                if (mostPoorPersonArray[i + 1] == "" || mostPoorPersonArray[i + 1] == null)
                {
                    mostPoorArraySize = i + 1;
                    break;
                }
            }

            return $"{FormatNameArray(mostPoorPersonArray)} {(mostPoorArraySize > 1 ? "have the least money." : "has the least money.")} {(lowerBalance >= 0 ? null : "-")}¤{(Math.Abs(lowerBalance).ToString())}.";
        }

        public static Person[] GetPeopleArray(string[] peopleAndBalances)
        {
            Person[] People = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var irregularArray = peopleAndBalances[i].Split(',');
                Person person = new Person();
                person.Name = irregularArray[0];

                for (int j = 1; j < irregularArray.Length; j++)
                {
                    decimal balance;
                    if (decimal.TryParse(irregularArray[j], NumberStyles.Any, new CultureInfo("en-US"), out balance))
                    {
                        person.Balance[j - 1] = balance;
                    }
                }

                People[i] = person;
            }

            return People;
        }
        
        private static string FormatNameArray(string[] nameArray)
        {
            if (nameArray[1] == "" || nameArray[1] == null)
                return nameArray[0];
            string formattedName = "";

            for (int i = 0; i < nameArray.Length; i++)
            {
                formattedName += nameArray[i];
                if (nameArray[i + 2] == "" || nameArray[i+2] == null)
                {
                    formattedName += $" and {nameArray[i + 1]}";
                    return formattedName;
                }
                else if (nameArray[i+1] != "")
                {
                    formattedName += ", ";
                }
            }
            return formattedName;
        }

        private static bool isArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }

        private static void AddName(string Name, string[] nameArray)
        {
            for (int i = 0; i < nameArray.Length; i++)
            {
                if (nameArray[i] == "" || nameArray[i] == null)
                {
                    nameArray[i] = Name;
                    return;
                }
            }
        }

        private static void ClearNameArray(string[] nameArray)
        {
            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = "";
            }
        }
    }
}
