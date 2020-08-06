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

            String TomName = "Tom Jefferson";
             int TomAge = 19;
            int TomWeight = 50;
            float TomHeight = 156.5f;

            Console.WriteLine(TomName + "is " + TomAge + " years old , his weight is "+TomWeight+ "kg and his height is " +TomHeight+ "cm" + ".");
            var TomBMI = (50 / (1.565*1.565));
            Console.WriteLine("Tom's Body mass index is " + TomBMI);

            

            string RahulName = "Rahul Reddy";
                int RahulAge = 25;
            int RahulWeight = 80;
            int RahulHeight = 180;

            Console.WriteLine(RahulName + "is " + RahulAge + "years old , his weight is" + RahulWeight + "kg and his height is " + RahulHeight + "cm" + ".");
            var RahulBMI = (80 / (1.80 * 1.80));
            Console.WriteLine("Rahul Body Mass Index is "+ RahulBMI);
             

            
          
        }
    }
}
