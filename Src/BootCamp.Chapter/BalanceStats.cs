using System.Text;
using System;
using System.Linq;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            float[] highest = MaxBalance(peopleAndBalances);

            // find highest number
            float maxNum = highest.Max();
            int poorPerson = Array.IndexOf(highest, maxNum);

            // link it to the person
            string[] people = Persons(peopleAndBalances);

            return $"{people[poorPerson]} had the most money ever. ¤{maxNum}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            float[] lowest = MinBalance(peopleAndBalances);

            // find highest number
            float minNum = lowest.Max();
            int poorPerson = Array.IndexOf(lowest, minNum);

            // link it to the person
            string[] people = Persons(peopleAndBalances);

            return $"{people[poorPerson]} lost the most money. -¤{minNum}.";
        }
        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            float[] totals = Totals(peopleAndBalances);

            // find highest number
            float maxNum = totals.Max();
            int poorPerson = Array.IndexOf(totals, maxNum);

            // link it to the person
            string[] people = Persons(peopleAndBalances);

            if (maxNum <= 0) return "N/A.";
            return $"{people[poorPerson]} is the richest person. ¤{maxNum}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }
            float[] totals = Totals(peopleAndBalances);

            // find highest number
            float minNum = totals.Min();
            int poorPerson = Array.IndexOf(totals, minNum);

            // link it to the person
            string[] people = Persons(peopleAndBalances);

            return $"{people[poorPerson]} has the least money. ¤{minNum}.";
        }

        public static string[] Persons(string[] peopleAndBalances)
        {

            string[] arr = new string[peopleAndBalances.Length];

            int i = 0;
            foreach (var person in peopleAndBalances)
            {
                arr[i] = person.Split(", ")[0];
                i++;
            }
            return arr;
        }

        public static float[] Totals(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            float[] Totals = new float[peopleAndBalances.Length];

            int i = 0;
            foreach (var balances in peopleAndBalances)
            {
                string numbers = balances.Split(", ")[^1];

                // Change string to numbers
                Totals[i] = float.Parse(numbers);
                i++;
            }
            return Totals;
        }

        public static float[] MaxBalance(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            float[] Maximum = new float[peopleAndBalances.Length];
            int i = 0;
            foreach (var balances in peopleAndBalances)
            {
                string[] total = balances.Split(", ");
                total = total.Skip(1).ToArray();

                float[] numbers = StringToFloat(total);

                float maxValue = numbers.Max();
                Maximum[i] = maxValue;
                i++;
            }
            return Maximum;
        }


        public static float[] MinBalance(string[] peopleAndBalances)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-GB");
            float[] Minimum = new float[peopleAndBalances.Length];
            int i = 0;
            foreach (var balances in peopleAndBalances)
            {
                string[] total = balances.Split(", ");
                total = total.Skip(1).ToArray();

                float[] numbers = StringToFloat(total);

                float minValue = numbers.Max() - numbers.Min();
                Minimum[i] = minValue;
                i++;
            }
            return Minimum;
        }
        public static float[] StringToFloat(string[] array)
        {
            float[] items = new float[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                float parsed;
                items[i] = float.TryParse(array[i], out parsed) ? parsed : 0f;
            }

            return items;
        }
    }
}
