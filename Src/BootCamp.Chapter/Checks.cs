using System;

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
            string poorestName = "";
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (i == 0)
                {
                    poorestName = account.GetName();
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance())
                {
                    if (personCount == 1)
                    {
                        poorestName += " and " + account.GetName();
                        personCount++;
                    }
                    else
                    {
                        poorestName = poorestName.Replace(" and ", ", ");
                        poorestName += " and " + account.GetName();
                        personCount++;
                    }
                }
                else if (amount > account.CurrentBalance())
                {
                    poorestName = account.GetName();
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringPoorestPeople(personCount, poorestName, amount);
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            string richestName = "";
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (i == 0)
                {
                    richestName = account.GetName();
                    amount = account.CurrentBalance();
                }
                else if (amount == account.CurrentBalance())
                {
                    if (personCount == 1)
                    {
                        richestName += " and " + account.GetName();
                        personCount++;
                    }
                    else
                    {
                        richestName = richestName.Replace(" and ", ", ");
                        richestName += " and " + account.GetName();
                        personCount++;
                    }
                }
                else if (amount < account.CurrentBalance())
                {
                    richestName = account.GetName();
                    amount = account.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringRichestPeople(personCount, richestName, amount);
        }
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            string biggestLossName = "";
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (account.MoreThan1Balance())
                {

                }
                else if (biggestLossName == "")
                {
                    biggestLossName = account.GetName();
                    amount = account.BiggestLoss();
                }
                else if (amount == account.BiggestLoss())
                {
                    if (personCount == 1)
                    {
                        biggestLossName += " and " + account.GetName();
                        personCount++;
                    }
                    else
                    {
                        biggestLossName = biggestLossName.Replace(" and ", ", ");
                        biggestLossName += " and " + account.GetName();
                        personCount++;
                    }
                }
                else if (amount > account.BiggestLoss())
                {
                    biggestLossName = account.GetName();
                    amount = account.BiggestLoss();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringBiggestLossPeople(biggestLossName, amount);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (Testers.IsThisStringArrayValid(peopleAndBalances))
            {
                return "N/A.";
            }
            string richestName = "";
            decimal amount = 0;
            int personCount = 1;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var account = new Account(MakeStuffWithInput.GetNameFromString(peopleAndBalances[i]), MakeStuffWithInput.GetBalanceFromString(peopleAndBalances[i]));

                if (i == 0)
                {
                    richestName = account.GetName();
                    amount = account.HighestBalanceEver();
                }
                else if (amount == account.HighestBalanceEver())
                {
                    if (personCount == 1)
                    {
                        richestName += " and " + account.GetName();
                        personCount++;
                    }
                    else
                    {
                        richestName = richestName.Replace(" and ", ", ");
                        richestName += " and " + account.GetName();
                        personCount++;
                    }
                }
                else if (amount < account.HighestBalanceEver())
                {
                    richestName = account.GetName();
                    amount = account.HighestBalanceEver();
                    personCount = 1;
                }
            }

            return MakeStuffWithInput.MakefullstringHighestBalanceEver(personCount, richestName, amount);
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
            var cl = new CleanTheFile();
            cl.Clean(file, outputFile);
        }
    }
}
