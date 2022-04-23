namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { 6, 2, 1, 4, 5 };
            cisla = ArrayOperations.InsertLast(cisla, 4);
            foreach (var cislo in cisla)
            {
                System.Console.Write($"{cislo} ");
            }
        }
    }
}
