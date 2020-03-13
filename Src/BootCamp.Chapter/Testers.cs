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
        public static void CheckForValidName(string name)
        {
            const string abc = " '-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int nameLength = name.Length;
            for (int i = 0; i < nameLength; i++)
            {
                if (!abc.Contains(name[i]))
                {
                    if (name[i] == '.' && i == nameLength -1)
                    {
                        return;
                    }
                    throw new InvalidBalancesException($"The name \"{name}\" Contains an invallid character.");
                }
            }
        }
        public static void CheckForValidBalance(string balance)
        {
            string[] splitLine = balance.Split(',');
            const string cash = "£€$  .1234567890-";
            for (int i = 1; i < splitLine.Length; i++)
            {
                for (int letter = 0; letter < splitLine[i].Length; letter++)
                {
                    if (!cash.Contains(splitLine[i][letter]))
                    {
                        throw new InvalidBalancesException($"The balance \"{splitLine[i]}\" Contains an invallid character.");
                    }
                }
            }
        }
    }
}
