using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Calculate
    {
        public void ProcessData(ILog log)
        {
            try
            {
                CalculateBMI(log); 
                Console.WriteLine("Once again? Y/N");
                var input = Console.ReadKey();
                if(input.KeyChar.ToString().ToUpper() == "Y")
                {
                    Console.WriteLine();
                    ProcessData(log);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            
        }
        public void CalculateBMI(ILog log)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your weight,unit is kg: ");
            float weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your height,unit is cm: ");
            float height = Convert.ToSingle(Console.ReadLine());

            float bmi = weight / ((height / 100) * (height / 100));

            string message = ($"{name} is {age} years old, weight is {weight} kg, height is {height} cm, BMI is {bmi}");
            log.WriteMessage(message);
        }
      
    }
}
