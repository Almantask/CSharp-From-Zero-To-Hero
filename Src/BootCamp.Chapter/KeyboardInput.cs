using System;

namespace BootCamp.Chapter
{
    public class KeyboardInput
    {
        public static int ReadLineReturnInt()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Not a integer, try again: ");
            }

            return result;
        }

        public static int ReadLineReturnInt(int min)
        {
            int result;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Not a integer, try again: ");
                }
                if(result < min)
                {
                    Console.Write($"Number may not be smaller than {min}, try again: ");
                }
            } while (result < min);

            return result;
        }

        public static int ReadLineReturnInt(int min, int max)
        {
            int result;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.Write("Not a integer, try again: ");
                }
                if (result < min)
                {
                    Console.Write($"Number may not be smaller than {min}, try again: ");
                }
                else if (result > max)
                {
                    Console.Write($"Number may not be greater than {max}, try again: ");
                }
            } while (result < min || result > max);

            return result;
        }
    }
}
