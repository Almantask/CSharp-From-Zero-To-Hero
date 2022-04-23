namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = null;
            cisla = ArrayOperations.InsertLast(cisla, 4);
            foreach (var cislo in cisla)
            {
                System.Console.Write($"{cislo} ");
            }
        }
    }
}
