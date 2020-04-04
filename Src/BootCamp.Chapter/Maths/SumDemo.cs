using System.Linq;

namespace BootCamp.Chapter.Maths
{
    public static class SumDemo
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 18, 5 };

            // Same results.
            // 20
            var v1 = SumLINQ(numbers);
            var v2 = SumForeach(numbers);
        }

        private static int SumLINQ(int[] numbers)
        {
            // Sums of all even numbers.
            return numbers.Sum(
                n => (n % 2 == 0)
                ?n:0);
        }

        private static int SumForeach(int[] numbers)
        {
            // Sum of all even numbers.
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}