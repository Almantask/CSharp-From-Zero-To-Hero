namespace BootCamp.Chapter.Objects
{
    public readonly struct DailySummary
    {
        public string Day { get; }
        public decimal Earn { get; }
        
        public DailySummary(string day, decimal earn)
        {
            Day = day;
            Earn = earn;
        }
    }
}