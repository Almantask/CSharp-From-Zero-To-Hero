using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Statistics
    {
        private double highestBalanceEver;
        private double personWithBiggestLoss;
        private double richestPerson;
        private double mostPoorPerson;
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
            Console.WriteLine($"{highestBalanceEverName}: {highestBalanceEver}");
            Console.WriteLine($"{personWithBiggestLossName}: {personWithBiggestLoss}");
            Console.WriteLine($"{richestPersonName}: {richestPerson}");
            Console.WriteLine($"{mostPoorPersonName}: {mostPoorPerson}");
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
    }
}
