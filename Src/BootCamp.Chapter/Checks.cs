namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return GetAnswer(peopleAndBalances, 1);
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return GetAnswer(peopleAndBalances, 2);
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return GetAnswer(peopleAndBalances, 3);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            return GetAnswer(peopleAndBalances, 4);
        }

        /// <summary>
        /// Pick answer
        /// </summary>
        /// <param name="peopleAndBalances"></param>
        /// <param name="answer">
        /// 1 - FindMostPoorPerson
        /// 2 - FindRichestPerson
        /// 3 - FindPersonWithBiggestLoss
        /// 4 - FindHighestBalanceEver
        /// </param>
        /// <returns></returns>
        public static string GetAnswer(string[] peopleAndBalances, int answer)
        {
            if (ArrayHandler.IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);

            switch (answer)
            {
                case 1:
                    return balanceStats.GetPoorestPersonAnswer();
                case 2:
                    return balanceStats.GetRichestPersonAnswer();
                case 3:
                    return balanceStats.GetPersonWithBiggestLossAnswer();                    
                case 4:
                    return balanceStats.GetHighestBalanceEverAnswer();
                default:
                    return "N/A.";
            }
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }
    }
}
