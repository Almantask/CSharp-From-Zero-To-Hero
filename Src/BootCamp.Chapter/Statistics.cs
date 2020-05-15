using System;
using System.Collections.Generic;
using System.Xml;

namespace BootCamp.Chapter
{
    class Statistics
    {
        private decimal highestBalanceEver;
        private decimal personWithBiggestLoss;
        private decimal richestPerson;
        private decimal mostPoorPerson;
        private string highestBalanceEverName;
        private string personWithBiggestLossName;
        private string richestPersonName;
        private string mostPoorPersonName;

        public Statistics()
        {
            highestBalanceEver = 0;
            personWithBiggestLoss = 0;
            richestPerson = 0;
            mostPoorPerson = 0;
        }

        public void CalculateStats()
        {
            UnpackFile fileContents = new UnpackFile();
            var accountNames = fileContents.ReturnAccounts();
            for(int i = 0; i < accountNames.Count; i++)
            {
                HighestBalanceEver(accountNames, i);
                PersonWithBiggestLoss(accountNames, i);
                RichestPerson(accountNames, i);
                MostPoorPerson(accountNames, i);
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine($"{highestBalanceEverName}: {ToCurrency(highestBalanceEver)}");
            Console.WriteLine($"{personWithBiggestLossName}: {ToCurrency(personWithBiggestLoss)}");
            Console.WriteLine($"{richestPersonName}: {ToCurrency(richestPerson)}");
            Console.WriteLine($"{mostPoorPersonName}: {ToCurrency(mostPoorPerson)}");
        }

        private void HighestBalanceEver(List<AccountDetails> accountDetails, int i)
        {
            var name = accountDetails[i].GetName();
            var highBal = accountDetails[i].HighestBalance();
            if (highBal > highestBalanceEver)
            {
                highestBalanceEverName = name;
                highestBalanceEver = Math.Max(highBal, highestBalanceEver);
            }
        }
        private void PersonWithBiggestLoss(List<AccountDetails> accountDetails, int i)
        {
            var name = accountDetails[i].GetName();
            var lowBal = accountDetails[i].BiggestLoss();
            if (lowBal < personWithBiggestLoss)
            {
                personWithBiggestLossName = name;
                personWithBiggestLoss = Math.Min(lowBal, personWithBiggestLoss);
            }
        }
        private void RichestPerson(List<AccountDetails> accountDetails, int i)
        {
            var name = accountDetails[i].GetName();
            var currBal = accountDetails[i].CurrentBalance();
            if (currBal > richestPerson)
            {
                richestPersonName = name;
                richestPerson = Math.Max(currBal, richestPerson);
            }
        }
        private void MostPoorPerson(List<AccountDetails> accountDetails, int i)
        {
            var name = accountDetails[i].GetName();
            var currBal = accountDetails[i].CurrentBalance();
            if (currBal < mostPoorPerson)
            {
                mostPoorPersonName = name;
                mostPoorPerson = Math.Min(currBal, mostPoorPerson);
            }
        }

        private string ToCurrency(decimal number)
        {
            var decToStr = $"{number}";

            if (number < 0)
            {
                return decToStr.Insert(1, "£");

            }
            else
            {
                return decToStr.Insert(0, "£");
            }
        }
    }
}
