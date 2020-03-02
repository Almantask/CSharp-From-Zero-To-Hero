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
            //TODO Find richest person!
            string richestName = "";
            decimal amount = 0;

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
                    richestName += " and " + a.GetName();
                }
                else if (amount < a.CurrentBalance())
                {
                    richestName = a.GetName();
                    amount = a.CurrentBalance();
                }
            }
            foreach (string person in peopleAndBalances)
            {
                


            }
            return richestName + " is the richest person. ¤" + amount + ".";
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
