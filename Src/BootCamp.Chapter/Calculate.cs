using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Calculate
    {
        public double Add(params int[] numbers)
        {
            var sum = 0;
            foreach(var x in numbers)
            {
                sum += x;
            }

            return sum;
        }

        public double Subtract(params int[] numbers)
        {
            var sum = numbers[0];
            for(int i = 1; i < numbers.Length; i++ )
            {
                sum -= numbers[i];
            }
            return sum;
        }
    }
}
