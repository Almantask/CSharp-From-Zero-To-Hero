namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            //TODO Find poorest person.
            return "";
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

            return makefullstringRichestPeople(personCount, richestName, amount);
        }
        private static string makefullstringRichestPeople(int numberOfPeople, string people, decimal amount)
        {
            string newString;
            if (numberOfPeople > 1)
            {
                newString = people + " are the richest people. ¤" + amount + ".";
            }
            else
            {
                newString = people + " is the richest person. ¤" + amount + ".";
            }
            return newString;
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            //TODO Find person with biggest loss!
            return "";
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
