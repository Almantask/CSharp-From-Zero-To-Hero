namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 2.
    /// </summary>
    public static class PeoplesBalances
    {
        /// <summary>
        /// Here are people and their balances.
        /// One line = one person.
        /// Line is made by name (no spaces), follow by balances separated by comma (",").
        /// Example: "Gily, 1, 0". Means that currently Gily has 0, which dropped from initial 1.
        /// </summary>
        public static string[] Balances => new[]
        {
            "Tom, 1", "Gillie, 1", "Agnes, 1"
        };

        public static string numbers = "1,2";
        
        
        public static void Demo()
        {
            //susplitinti per kablelį elementus("1" "2") 
            //sukti for loop pirmo step rezultatui ir tada daryti 3 step
            //suparsinti stringą (pvz.: "1") į int (1, 2)
            //ir sudėti.
            int sum = 0;
            string[] newNumber = numbers.Split(",");

            for(int i = 0; i<newNumber.Length; i++)
            {
                int number = int.Parse(newNumber[i]);
                sum += number;
            }
        }
    }
}
