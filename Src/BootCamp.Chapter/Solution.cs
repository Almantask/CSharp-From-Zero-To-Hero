using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Solution
    {
        public int MyAtoi(string input)
        {
            var parsedInput = new StringBuilder();
            for (int i = 0; i < input.Length  ; i++)
            {
                if ((input[i]  == ' ') || (input[i] == '+'))
                {
                    continue; 
                }
                else if ((input[i] >= '0' && input[i] <= '9') || input[i] == '-')
                {
                    parsedInput.Append(input[i]); 
                }
                else if ((i != input.Length -1) &&(input[i + 1] >= '0' && input[i+1] <= '9'))
                {
                    continue; 
                }
                else
                {
                    break; 
                }
            }

            double.TryParse(parsedInput.ToString(), out double output);

            if (output > int.MaxValue)
            {
                output = int.MaxValue; 
            }

            if (output < int.MinValue)
            {
                output = int.MinValue; 
            }

            return (int)output;  
        }
    }
}
