using System;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.

    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            StringBuilder poorestName = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            //TODO The body of the for loop could be refactored into a function (or a few) so that it is easier to skim through the bigger function.
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                CheckIfThisPersonIsPoorer(account, i);
            }

            return MakeStuffWithInput.MakefullstringPoorestPeople(personCount, poorestName.ToString(), amount);



            
            void CheckIfThisPersonIsPoorer(Account account, int i)
            {
                if (i == 0) // first account to be added is alway's the poorest.
                {
                    poorestName.Append(account.GetName());
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance()) // this account has the same balance as current.
                {
                    if (personCount == 1) // the second account to be added
                    {
                        poorestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                    else // any others
                    {
                        poorestName.Replace(" and ", ", ");
                        poorestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                }
                else if (amount > account.CurrentBalance()) // this is now the poorest account.
                {
                    poorestName.Clear();
                    poorestName.Append(account.GetName());
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            StringBuilder richestName = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (i == 0)
                {
                    richestName.Append(account.GetName());
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance())
                {
                    if (personCount == 1)
                    {
                        richestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                    else
                    {
                        richestName.Replace(" and ", ", ");
                        richestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                }
                else if (amount < account.CurrentBalance())
                {
                    richestName.Clear();
                    richestName.Append(account.GetName());
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringRichestPeople(personCount, richestName.ToString(), amount);
        }
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            StringBuilder biggestLossName = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (account.MoreThan1Balance())
                {

                }
                else if (biggestLossName.ToString() == "")
                {
                    biggestLossName.Append(account.GetName());
                    amount = account.BiggestLoss();
                }
                else if (amount == account.BiggestLoss())
                {
                    if (personCount == 1)
                    {
                        biggestLossName.Append(" and " + account.GetName());
                        personCount++;
                    }
                    else
                    {
                        biggestLossName.Replace(" and ", ", ");
                        biggestLossName.Append(" and " + account.GetName());
                        personCount++;
                    }
                }
                else if (amount > account.BiggestLoss())
                {
                    biggestLossName.Clear();
                    biggestLossName.Append(account.GetName());
                    amount = account.BiggestLoss();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringBiggestLossPeople(biggestLossName.ToString(), amount);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            StringBuilder richestName = new StringBuilder();
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (i == 0)
                {
                    richestName.Append(account.GetName());
                    amount = account.HighestBalanceEver();
                }
                else if (amount == account.HighestBalanceEver())
                {
                    if (personCount == 1)
                    {
                        richestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                    else
                    {
                        richestName.Replace(" and ", ", ");
                        richestName.Append(" and " + account.GetName());
                        personCount++;
                    }
                }
                else if (amount < account.HighestBalanceEver())
                {
                    richestName.Clear();
                    richestName.Append(account.GetName());
                    amount = account.HighestBalanceEver();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringHighestBalanceEver(personCount, richestName.ToString(), amount);
        }

        public static string Build(string message, in int padding)
        {
            if (Testers.IsThisStringValid(message))
            {
                return "";
            }
            return MakeStuffWithInput.MakePadding(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            CleanTheFile.Clean(file, outputFile);
        }
    }
}
