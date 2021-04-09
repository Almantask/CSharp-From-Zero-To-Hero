using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        private string name;
        private int[] amount;

        public Person(string personStr)
        {
            string[] words = personStr.Split(",");
            this.name = words[0];
            this.amount = new int[words.Length - 1];
            for (int i = 1; i <= amount.Length; i++)
            {
                amount[i - 1] = int.Parse(words[i]);
            }
        }

        public string GetPersonName()
        {
            return name;
        }

        public int GetHighestMoneyEver()
        {
            int highestMoneyEver = int.MinValue;
            for (int i = 0; i < amount.Length; i++)
            {
                if (amount[i] > highestMoneyEver)
                {
                    highestMoneyEver = amount[i];
                }
            }
            return highestMoneyEver;
        }

        public int GetLowestMoneyEver()
        {
            int LowesetMoneyEver = int.MaxValue;
            for(int i = 0; i < amount.Length; i++)
            {
                if(amount[i] < LowesetMoneyEver)
                {
                    LowesetMoneyEver = amount[i];
                }
            }
            return LowesetMoneyEver;
        }
        public int GetTheBiggestChange()
        {
            int biggestChange = int.MinValue;
            for(int i = 0; i < amount.Length - 1; i++)
            {
                if (amount[i] > amount[i + 1])
                {
                    biggestChange = amount[i] - amount[i + 1];
                }
            }
            
            return biggestChange;

        }

        public int GetCurrentMoney()
        {
            return amount[amount.Length - 1];
        }
    }
}
