using System;

namespace BootCamp.Chapter
{
    public delegate void Alarm();

    // Delegate definition is very much like a function definition.
    // There are only 2 differences: extra keyword- delegate.
    // And the fact that they exist outside a class scope.
    public delegate void MyDelegate(/*input*/);

    class Program
    {
        static void Main(string[] args)
        {
            HouseAlarmDemo();

            Action action = () => Console.WriteLine("Hello delegates!");
            Call(action);
        }

        public static void Call(Action action)
        {
            action();
        }

        private static void HouseAlarmDemo()
        {
            var house = new House();
            house.AlarmTriggered += House_AlarmTriggered;
            house.Alarm += () => Console.WriteLine();

            house.Open();
            house.Open();
        }

        private static void House_AlarmTriggered(object sender, EventArgs e) => Console.WriteLine("Hello");
    }

    public class House
    {
        public event EventHandler AlarmTriggered;
        public event Alarm Alarm;

        public House()
        {

        }

        public void Open()
        {
            AlarmTriggered?.Invoke(this, null);
        }
    }


}
