namespace BMISLeslie
{
    class Program
    {
        private static void Main(string[] args)
        {
            //First Person
            //Console Entries and add value to variables
            Console.WriteLine("Please enter your first name:");
            string name = (Console.ReadLine());
            Console.WriteLine("Please Enter your surname:");
            string surname = (Console.ReadLine());
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm:");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your weight in kg:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            //Work out BMI
            decimal bmi = weight / ((height / 100) * (height / 100));

            //Printout
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cms. His BMI is {Math.Round(bmi, 2)}.");

            //2nd Person
            //Console Entries and add value to variables
            Console.WriteLine("Please enter your first name:");
            name = (Console.ReadLine());
            Console.WriteLine("Please Enter your surname:");
            surname = (Console.ReadLine());
            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm:");
            height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your weight in kg:");
            weight = Convert.ToDecimal(Console.ReadLine());

            //Work out BMI
            bmi = weight / ((height / 100) * (height / 100));

            //Printout
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cms. His BMI is {Math.Round(bmi, 2)}.");
        }
    }
}
