using System;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "asdasa";
            WriteLine(MostCommonLetterFinder.Find(s)); //a
            var like =new bool[][] { new bool[]{false, false},new bool[]{false} };
            ToggleableGridJagged jagged = new ToggleableGridJagged(like, null);
            jagged.Toggle(0, 1); //■■
            jagged.Toggle(0, 1); //  
            jagged.Toggle(0, 0); //■

        }
    }
}
