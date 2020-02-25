using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

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
            if (IsArrayNullOrEmpty(peopleAndBalances))
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
            var fc = new FileCleaner();
            fc.Clean(file, outputFile);


            //if (String.IsNullOrEmpty(file) || String.IsNullOrEmpty(outputFile))
            //{
            //    throw new ArgumentException("File path is null or empty.");
            //}

            //var corruptedFileContent = File.ReadAllText(file);
            //if (String.IsNullOrEmpty(corruptedFileContent))
            //{
            //    File.WriteAllText(outputFile, corruptedFileContent);
            //    return;
            //}

            //var cleanFileContent = corruptedFileContent.Replace("_", "");

            //try
            //{
            //    ValidateName(cleanFileContent);
            //    ValidateBalance(cleanFileContent);
            //}
            //catch (Exception ex)
            //{
            // //   throw new InvalidBalancesException("Invalid name or Balance format", ex);
            //}

          //  File.WriteAllText(outputFile, cleanFileContent);
        }
        public static void ValidateBalance(string fileContent)
        {
            var peopleAndBalances = fileContent.Split(Environment.NewLine);
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                ConvertToBalanceArray(peopleAndBalances[i]);
            }
        }
        public static void ValidateName(string fileContent)
        {
            var name = ConvertToArray(fileContent)[0];
            foreach (char letter in name)
            {
                if (!Char.IsLetter(letter) && !letter.Equals(' '))
                {
                    throw new ArgumentException("Name contains invalid characters!");
                }
            }
        }
        public static float[] ConvertToBalanceArray(string personAndBalance)
        {
            string[] personAndBalanceArray = ConvertToArray(personAndBalance);

            if (personAndBalanceArray.Length == 1)
            {
                float[] noBalance = new float[] { 0 };
                return noBalance;
            }

            float[] balance = new float[personAndBalanceArray.Length - 1];

            for (int i = 1; i < personAndBalanceArray.Length; i++)
            {
                // in this case not using try parse, becase it is known 
                // that array have only numbers 

                balance[i - 1] = float.Parse(personAndBalanceArray[i], NumberStyles.Currency);
            }
            return balance;
        }
        public static string[] ConvertToArray(string personAndBalance)
        {
            // this to remove white spaces in string array
            personAndBalance = personAndBalance.Replace(", ", ",");
            string[] personAndBalanceArray = personAndBalance.Split(',');
            return personAndBalanceArray;
        }

        public static bool IsArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }




    }
}
