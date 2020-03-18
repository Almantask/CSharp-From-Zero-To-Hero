using System;
using BootCamp.Chapter.Examples.NullCoalecingDemo;

namespace BootCamp.Chapter.Examples.NullCoalecing
{
    public static class NullCoalecingDemo
    {
        public static void Run()
        {
            DemoInvalidPeople();
            DemoLift();
        }

        private static void DemoInvalidPeople()
        {
            try
            {
                new Person1(null, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                new Person2(null, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DemoLift()
        {
            var people = new Person1[] { new Person1("Tom", 18), null };

            if (CanMoveUpElevator(people))
            {
                Console.WriteLine("Going up.");
            }
            else
            {
                Console.WriteLine("Staying down.");
            }
        }

        private static bool CanMoveUpElevator(Person1[] people)
        {
            var totalWeight = SumWeight2(people);
            const double maxWeight = 500;

            return totalWeight < maxWeight;
        }

        private static double SumWeight2(Person1[] people)
        {
            var totalWeight = 0;
            foreach (var person in people)
            {
                totalWeight += person?.Weight ?? 0;
            }

            return totalWeight;
        }

        private static double SumWeight1(Person1[] people)
        {
            var totalWeight = 0;
            foreach (var person in people)
            {
                if (person != null)
                {
                    totalWeight += person.Weight;
                }
            }

            return totalWeight;
        }
    }
}
