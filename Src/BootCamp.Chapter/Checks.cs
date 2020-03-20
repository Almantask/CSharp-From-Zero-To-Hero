﻿using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.

    public static class Checks
    {
        const string nA = "N/A.";
        const string and = " and ";
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return nA;
            }
            StringBuilder name = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                IsMorePoor(ParseAccount(peopleAndBalances[i]), i);
            }

            return MakeStuffWithInput.MakefullstringPoorestPeople(personCount, name.ToString(), amount);

            void IsMorePoor(Account account, int i)
            {
                if (i == 0) // first account to be added is alway's the poorest.
                {
                    name.Append(account.GetName());
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance()) // this account has the same balance as current.
                {
                    personCount = AddPersonToExising(name, personCount, account);
                }
                else if (amount > account.CurrentBalance()) // this is now the poorest account.
                {
                    name.Clear();
                    name.Append(account.GetName());
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return nA;
            }
            StringBuilder name = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                Account account = ParseAccount(peopleAndBalances[i]);

                if (i == 0)
                {
                    name.Append(account.GetName());
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance())
                {
                    personCount = AddPersonToExising(name, personCount, account);
                }
                else if (amount < account.CurrentBalance())
                {
                    name.Clear();
                    name.Append(account.GetName());
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringRichestPeople(personCount, name.ToString(), amount);
        }
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return nA;
            }
            StringBuilder name = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                Account account = ParseAccount(peopleAndBalances[i]);

                if (account.GetBalance().Length < 2)
                {

                }
                else if (name.ToString() == string.Empty)
                {
                    name.Append(account.GetName());
                    amount = account.BiggestLoss();
                }
                else if (amount == account.BiggestLoss())
                {
                    personCount = AddPersonToExising(name, personCount, account);
                }
                else if (amount > account.BiggestLoss())
                {
                    name.Clear();
                    name.Append(account.GetName());
                    amount = account.BiggestLoss();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringBiggestLossPeople(name.ToString(), amount);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return nA;
            }
            StringBuilder name = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                Account account = ParseAccount(peopleAndBalances[i]);

                if (i == 0)
                {
                    name.Append(account.GetName());
                    amount = account.HighestBalanceEver();
                }
                else if (amount == account.HighestBalanceEver())
                {
                    personCount = AddPersonToExising(name, personCount, account);
                }
                else if (amount < account.HighestBalanceEver())
                {
                    name.Clear();
                    name.Append(account.GetName());
                    amount = account.HighestBalanceEver();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringHighestBalanceEver(personCount, name.ToString(), amount);
        }

        private static int AddPersonToExising(StringBuilder name, int personCount, Account account)
        {
            if (personCount == 1)
            {
                name.Append(and + account.GetName());
            }
            else
            {
                name.Replace(and, ", ");
                name.Append(and + account.GetName());
            }
            return personCount + 1;
        }

        public static string Build(string message, in int padding)
        {
            if (Testers.IsThisStringValid(message))
            {
                return string.Empty;
            }
            return MakeStuffWithInput.MakePadding(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            CleanTheFile.Clean(file, outputFile);
        }

        private static Account ParseAccount(string peopleAndBalances)
        {
            string name = MakeStuffWithInput.GetNameFromString(peopleAndBalances);
            decimal[] balance = MakeStuffWithInput.GetBalanceFromString(peopleAndBalances);

            return new Account(name, balance);
        }
    }
}
