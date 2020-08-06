using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1and2
{
    class Program
    {
        static void Main(string[] args)
        { // PRess enter or type anything and the the code will appear.
            string name = Console.ReadLine();
            Console.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.");

            var TomBMI = (50 / (1.565*1.565));
            Console.WriteLine("Tom's Body mass index is " + TomBMI);

            string Rahul = Console.ReadLine();

            Console.WriteLine("Rahul is 25 years old, his weight is 80kg and his height is 180 cm");
            var RahulBMI = (80 / (1.80 * 1.80));
            Console.WriteLine("Rahul Body mass index is " + RahulBMI );

          
        }
    }
}
