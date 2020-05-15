namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            FileCleaner cleaningfile = new FileCleaner();
            cleaningfile.CleaningCorruptedFile();
            Statistics statistics = new Statistics();
            statistics.CalculateStats();
            statistics.DisplayStats();    
        }
    }
}
