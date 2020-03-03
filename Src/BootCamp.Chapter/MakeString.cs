using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class MakeString
    {
        public static string MakefullstringRichestPeople(int numberOfPeople, string people, decimal amount)
        {
            if (numberOfPeople > 1)
            {
                return people + " are the richest people. ¤" + amount + ".";
            }
            else
            {
                return people + " is the richest person. ¤" + amount + ".";
            }
        }
        public static string MakefullstringPoorestPeople(int numberOfPeople, string people, decimal amount)
        {
            if (numberOfPeople > 1)
            {
                if (amount < 0)
                {
                    return people + " have the least money. -¤" + Math.Abs(amount) + ".";
                }
                else
                {
                    return people + " have the least money. ¤" + amount + ".";
                }

            }
            else
            {
                if (amount < 0)
                {
                    return people + " has the least money. -¤" + Math.Abs(amount) + ".";
                }
                else
                {
                    return people + " has the least money. ¤" + amount + ".";
                }

            }
        }
        public static string MakefullstringBiggestLossPeople(string people, decimal amount)
        {
            if (people == "")
            {
                return "N/A.";
            }
            if (amount < 0)
            {
                return people + " lost the most money. -¤" + Math.Abs(amount) + ".";
            }
            else
            {
                return people + " lost the most money. ¤" + amount + ".";
            }

        }

    }
}
