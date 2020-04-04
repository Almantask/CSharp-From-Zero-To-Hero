using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Querying
{
    public static class FirstOrDefaultDemo
    {
        public static void Run()
        {
            FirstOrDefaultNoFilterDemo();
            FirstOrDefaultWithFilterDemo();
        }

        private static void FirstOrDefaultNoFilterDemo()
        {
            int[] numbers = { };
            // 0
            var result = numbers.FirstOrDefault();

            int[] numbers2 = { 5 };
            // 5
            var result2 = numbers.FirstOrDefault();

            int[] numbers3 = { };
            // Exception
            //var result3 = numbers.First();
        }

        private static void FirstOrDefaultWithFilterDemo()
        {
            var names = new[] {"Joshmond", "Kaisinel", "Roelof", "Mihail", "HellHunter", "Aurora"};
            var nameStartingWithJ = names.FirstOrDefault(w => w.StartsWith('J'));

            Console.WriteLine(nameStartingWithJ);
        } 
    }
}
