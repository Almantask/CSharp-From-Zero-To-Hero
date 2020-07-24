using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) peopleAndBalances = new string[0];
            var stringContent = new PeopleAndBalances(String.Join(Environment.NewLine, peopleAndBalances));

            string highestEver = stringContent.FindHighestBalanceEver();
            return highestEver;
        }

        public static string Build(string message, in int padding)
        {
            return "";
        }

        public static void Clean(string file, string outputFile)
        {
            var fileWithBalances = new FileWithBalances(file);
            string cleanedContent = fileWithBalances.GetContent();
            File.WriteAllText(outputFile, cleanedContent);
        }
    }
}
