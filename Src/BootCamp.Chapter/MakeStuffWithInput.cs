using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class MakeStuffWithInput
    {
        //TODO Make the Stringmakers more streamlined so they can be called and read more easy. and modular.

        /// <summary>
        /// This Gives back a string that reads: people are/is the richest people. ¤ amount. 
        /// </summary>
        /// <param name="numberOfPeople"></param>
        /// <param name="people">string of person or persons</param>
        /// <param name="amount">the amount of money</param>
        /// <returns></returns>
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
        /// <summary>
        /// This Gives back a string that reads: people have the least money. -¤=amount.
        /// </summary>
        /// <param name="numberOfPeople"></param>
        /// <param name="people">string of person or persons</param>
        /// <param name="amount">the amount of money</param>
        /// <returns></returns>
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
        /// <summary>
        /// Gives back a string that reads: people lost the most money. ¤ amount.
        /// </summary>
        /// <param name="people">string of person or persons</param>
        /// <param name="amount">the amount of money</param>
        /// <returns></returns>
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
        /// <summary>
        /// Gives back a string that reads: people had the most money ever. ¤ amount.
        /// </summary>
        /// <param name="numberOfPeople"></param>
        /// <param name="people">string of person or persons</param>
        /// <param name="amount">the amount of money</param>
        /// <returns></returns>
        public static string MakefullstringHighestBalanceEver(int numberOfPeople, string people, decimal amount)
        {
            if (people == "")
            {
                return "N/A.";
            }
            if (numberOfPeople > 1)
            {
                return people + " had the most money ever. ¤" + amount + ".";
            }
            else
            {
                return people + " had the most money ever. ¤" + amount + ".";
            }

        }
        public static string MakePadding(string message, int padding)
        {
            const string corner = "+";
            const string horizontal = "-";
            const string vertical = "|";

            string[] splitmessage = message.Split(Environment.NewLine);
            int height = splitmessage.Length + (padding * 2) + 1;
            int width = 0;

            foreach (string line in splitmessage)
            {
                if(line.Length > width)
                {
                    width = line.Length;
                }
            }
            width += (padding * 2) + 1;
            return MakeTabel();

            string MakeTabel()
            {
                StringBuilder final = new StringBuilder();
                for (int iHeight = 0; iHeight <= height; iHeight++)
                {
                    for (int kWidth = 0; kWidth <= width; kWidth++)
                    {

                        if (IsThisCorner(iHeight, kWidth))
                        {
                            final.Append(corner);
                        }
                        else if (IsThisHorizontal(iHeight, kWidth))
                        {
                            final.Append(horizontal);
                        }
                        else if (IsThisVertical(iHeight, kWidth))
                        {
                            final.Append(vertical);
                        }
                        else if (IsThisText(iHeight, kWidth))
                        {
                            final.Append(WhatLetterToBePlaced(iHeight, kWidth));
                        }
                        else if (IsThisWhiteSpace(iHeight, kWidth))
                        {
                            final.Append(" ");
                        }
                    }
                    final.Append(Environment.NewLine);
                }
                return final.ToString();
            }
            bool IsThisCorner(int iHeight, int kWidth)
            {
                // corners = 0 + 0 =====  0 + width === height + 0 === height + width
                if ((iHeight == 0 && kWidth == 0) || (iHeight == 0 && kWidth == width)||
                    (iHeight == height && kWidth == 0)|| (iHeight == height && kWidth == width))
                {
                    return true;
                }

                return false;
            }
            bool IsThisHorizontal(int iHeight, int kWidth)
            {
                // horizontal = height 0 !& width 0 !& width maxwidth || height max !& width 0 !& width maxwidth
                if ((iHeight == 0 && !(kWidth == 0 || kWidth == width)) || (iHeight == height && !(kWidth == 0 || kWidth == width)))
                {
                    return true;
                }
                return false;
            }
            bool IsThisVertical(int iHeight, int kWidth)
            {
                // vertical oposite of horizontal
                if ((kWidth == 0 && !(iHeight == 0 || iHeight == height)) || (kWidth == width && !(iHeight == 0 || iHeight == height)))
                {
                    return true;
                }
                return false;
            }
            bool IsThisWhiteSpace(int iHeight, int kWidth)
            {
                if (kWidth != 0 && kWidth != width && iHeight != 0 && iHeight != height)
                {
                    return true;
                }
                return false;
            }
            bool IsThisText(int iHeight, int kWidth)
            {
                int numberOfTextLines = splitmessage.Length;
                int heightOfFirstTextLine = 1 + padding;
                int textRow = iHeight - heightOfFirstTextLine;

                if (iHeight >= heightOfFirstTextLine && iHeight < heightOfFirstTextLine + numberOfTextLines)
                {
                    if (kWidth >= heightOfFirstTextLine && kWidth < heightOfFirstTextLine + splitmessage[textRow].Length)
                    {
                        return true;
                    }
                }
                return false;
            }
            string WhatLetterToBePlaced(int iHeight, int kWidth)
            {
                int heightOfFirstTextLine = 1 + padding;
                int textRow = iHeight - heightOfFirstTextLine;
                int letternumber = kWidth - heightOfFirstTextLine;

                return splitmessage[textRow][letternumber].ToString();
            }
        }
        public static string GetNameFromString(string nameAndBalance)
        {
            string[] splitNameAndBalance = nameAndBalance.Split(',');

            return splitNameAndBalance[0];
        }
        public static decimal[] GetBalanceFromString(string nameAndBalance)
        {
            string[] splitNameAndBalance = nameAndBalance.Split(',');

            decimal[] balance = new decimal[splitNameAndBalance.Length - 1];

            for (int i = 1; i < splitNameAndBalance.Length; i++)
            {
                Decimal.TryParse(splitNameAndBalance[i], out balance[i - 1]);
            }
            return balance;
        }

    }
}
