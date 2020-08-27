using System;

namespace BootCamp.Chapter
{
    public static class Demo
    {
        public static void Run()
        {
            PostOfficeHq postOfficeHq = new PostOfficeHq();
            PrintPostOfficesAndStats(postOfficeHq);
        }

        private static void PrintPostOfficesAndStats(PostOfficeHq postOfficeHq)
        {
            foreach (var postOffice in postOfficeHq.ListOfPostOffices)
            {
                PrintAddresses(postOffice);
                Console.WriteLine($"Duplicate Count: {postOffice.DuplicateCount}");
            }
        }

        private static void PrintAddresses(PostOffice postOffice)
        {
            Console.WriteLine($"Postal Addresses handled by: Post Office - {postOffice.Location}");
            foreach (var address in postOffice.PostAddresses)
            {
                Console.WriteLine($"{address.Recipient},{address.Street},{address.Town}");
            }
        }
    }
}
