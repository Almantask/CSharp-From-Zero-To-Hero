using System;

namespace BootCamp.Chapter
{
    
    class Program
    {

        static void Main(string[] args)
        {
            while (InteractionsManager.ContinueRunningProgram)
            {
                InteractionsManager.PerformInteractions();
            }
        }

    }


}
