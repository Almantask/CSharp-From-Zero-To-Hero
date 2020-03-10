using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Bmi
    {
        private static readonly string messageBmi = $"Failed calculating BMI. Reason:";
        private static readonly string messageWeight = $"Weight cannot be equal or less than zero, but was ";
        private static readonly string messageHeight = $"Height cannot be equal or less than zero, but was ";
        private static readonly string messageHeightLessZero = $"Height cannot be less than zero, but was ";

        public static float Calculate(Person person)
        {
            if (person.GetHeigth() <= 0 && person.GetHeigth() <= 0)
            {
                Logger.Log($"{messageBmi}{Environment.NewLine}{messageWeight}{Environment.NewLine}{messageHeightLessZero}.");
                return -1;
            }
            else if (person.GetWeight() <= 0)
            {
                Logger.Log($"{messageBmi}{Environment.NewLine}{messageWeight}.");
                return -1;
            }
            else if (person.GetHeigth() <= 0)
            {
                Logger.Log($"{messageBmi}{Environment.NewLine}{messageHeight}.");
                return -1;
            }
            else
            {
                return person.GetWeight() / (float)Math.Pow(person.GetHeigth(), 2);
            }
        }
    }
}