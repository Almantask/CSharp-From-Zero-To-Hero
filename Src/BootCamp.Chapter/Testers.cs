using System;

namespace BootCamp.Chapter
{
    public static class Testers
    {
        public static bool IsThisStringValid(string file)
        {
            return (String.IsNullOrEmpty(file) || String.IsNullOrWhiteSpace(file));
        }
        public static bool IsThisStringArrayValid(this Array array)
        {
            return (array == null || array.Length == 0);
        }
        public static bool IsThisAValidName(string name)
        {
            const string abc = " '-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int nameLength = name.Length;
            for (int i = 0; i < nameLength; i++)
            {
                if (!abc.Contains(name[i]))
                {
                    if (name[i] == '.' && i == nameLength -1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }
        public static bool IsThisAValidBalance(string balance)
        {
            string[] splitLine = balance.Split(',');
            const string cash = "£€$  .1234567890-";
            for (int i = 1; i < splitLine.Length; i++)
            {
                for (int letter = 0; letter < splitLine[i].Length; letter++)
                {
                    if (!cash.Contains(splitLine[i][letter]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static string WhatIsNotValid(string balance)
        {
            string[] splitLine = balance.Split(',');
            const string cash = "£€$  .1234567890-";
            const string abc = " '-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int nameLength = splitLine[0].Length;
            for (int i = 0; i < nameLength; i++)
            {
                if (!abc.Contains(splitLine[0][i]))
                {
                    if (splitLine[0][i] == '.' && i == nameLength - 1)
                    {
                        continue;
                    }
                    return $"{splitLine[0]} Contains a invallid character."; ;
                }
            }
            for (int i = 1; i < splitLine.Length; i++)
            {
                for (int letter = 0; letter < splitLine[i].Length; letter++)
                {
                    if (!cash.Contains(splitLine[i][letter]))
                    {
                        return $"{splitLine[i]} Contains a invallid character.";
                    }
                }
            }
            return "nothing is wrong with this string.";
        }
    }
}
