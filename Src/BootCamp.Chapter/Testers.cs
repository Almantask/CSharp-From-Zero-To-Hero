using System;
using System.Collections.Generic;
using System.Text;

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
            string abc = " '-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
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
            //TODO ValidNameChecker!
            string[] splitLine = balance.Split(',');

            for (int i = 1; i < splitLine.Length; i++)
            {
                //if (splitLine[i] is not a correct balance)
                // return false;
            }
            return true;
        }
    }
}
