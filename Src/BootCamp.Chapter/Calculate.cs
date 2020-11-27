using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Calculate
    {
        public void CalculateBMI(ILog log)
        {
            try
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

                log.WriteMessage($"{name} is {age} years old, weight is {weight} kg, height is {height} cm, BMI is {bmi}");

                Console.WriteLine("Once again? Y/N");
                var input = Console.ReadKey();
                if(input.KeyChar.ToString().ToUpper() == "Y")
                {
                    Console.WriteLine();
                    CalculateBMI(log);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            
        }
      
    }
}
