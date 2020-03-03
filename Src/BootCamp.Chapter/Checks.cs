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
                var a = new Account(peopleAndBalances[i]);
                if (i == 0)
                {
                    poorestName = a.GetName();
                    amount = a.CurrentBalance();
                }
                else if (amount == a.CurrentBalance())
                {
                    if (personCount == 1)
                    {
                        poorestName += " and " + a.GetName();
                        personCount++;
                    }
                    else
                    {
                        poorestName = poorestName.Replace(" and ", ", ");
                        poorestName += " and " + a.GetName();
                        personCount++;
                    }
                }
                else if (amount > a.CurrentBalance())
                {
                    poorestName = a.GetName();
                    amount = a.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeString.MakefullstringPoorestPeople(personCount, poorestName, amount);
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
                var a = new Account(peopleAndBalances[i]);
                if (i == 0)
                {
                    richestName = a.GetName();
                    amount = a.CurrentBalance();
                }
                else if (amount == a.CurrentBalance())
                {
                    if (personCount == 1)
                    {
                        richestName += " and " + a.GetName();
                        personCount++;
                    }
                    else
                    {
                        richestName = richestName.Replace(" and ", ", ");
                        richestName += " and " + a.GetName();
                        personCount++;
                    }
                }
                else if (amount < a.CurrentBalance())
                {
                    richestName = a.GetName();
                    amount = a.CurrentBalance();
                    personCount = 1;
                }
            }

            return MakeString.MakefullstringRichestPeople(personCount, richestName, amount);
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
                var a = new Account(peopleAndBalances[i]);
                if (a.MoreThan1Balance())
                {

                }
                else if (biggestLossName == "")
                {
                    biggestLossName = a.GetName();
                    amount = a.BiggestLoss();
                }
                else if (amount == a.BiggestLoss())
                {
                    if (personCount == 1)
                    {
                        biggestLossName += " and " + a.GetName();
                        personCount++;
                    }
                    else
                    {
                        biggestLossName = biggestLossName.Replace(" and ", ", ");
                        biggestLossName += " and " + a.GetName();
                        personCount++;
                    }
                }
                else if (amount > a.BiggestLoss())
                {
                    biggestLossName = a.GetName();
                    amount = a.BiggestLoss();
                    personCount = 1;
                }
            }

            return MakeString.MakefullstringBiggestLossPeople(biggestLossName, amount);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            //TODO Find highest balence person
            return "";
        }

        public static string Build(string message, in int padding)
        {
            //TODO Build a nice framework for the info of people
            return "";
        }

        public static void Clean(string file, string outputFile)
        {
            var cl = new CleanTheFile();
            cl.Clean(file, outputFile);
        }
    }
}
