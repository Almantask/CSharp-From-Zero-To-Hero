using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class TheoryExamples
    {

        // Delegate definition is very much like a function definition.
        // There are only 2 differences: extra keyword- delegate.
        // And the fact that they exist outside a class scope.
        //public delegate void MyDelegate(/*input*/);
        public delegate void MyDelegate();
        public delegate bool MyPredicate();

        // This is exactly the same as EventHandler<T>
        public delegate void DuplicateEventHandler<in T>(object sender, T eventArgs)
            where T : EventArgs;

        class Person
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        private static void AnonymUnsubscribeDemo()
        {
            Action action = () => Console.Write("1");
            action += () => Console.Write("2");
            action -= () => Console.Write("1");
            action();
        }

        private static void PredicateDemo()
        {
            var person1 = new Person("Tom", 18);
            var person2 = new Person("Bill", 7);

            Predicate<Person> isOverEighteen = (person) => person.Age > 18;
            isOverEighteen(person1);
            isOverEighteen(person2);
        }

        private static void FuncDemo()
        {
            Func<bool> function1 = () => true;
            Func<int, int, bool> areEqual = (a, b) => a == b;

            var result1 = function1();
            var result2 = areEqual(1, 1);
        }

        private static void ActionDemo()
        {
            Action action1 = () => Console.WriteLine("Hello anonymous!");
            Action<string> action2 = (name) => Console.WriteLine($"Hello {name}");

            action1();
            action2("Kaisi");
        }

        private static void DelegatesChaining()
        {
            MyDelegate action = FunctionThatImplementsMyDelegate;
            action += AnotherFunctionThatImplementsMyDelegate;
            // Calls both functions one after another.
            action();

            action -= AnotherFunctionThatImplementsMyDelegate;
            // Just calls the initial function.
            action();

            MyPredicate predicate1 = Predicate1;
            predicate1 += Predicate2;

            bool result = Predicate1();
            Console.WriteLine(result);
        }

        public static void FunctionThatImplementsMyDelegate() {/*..*/}
        public static void AnotherFunctionThatImplementsMyDelegate() {/*..*/}

        public static bool Predicate1() => true;
        public static bool Predicate2() => false;

        public static void Call(MyDelegate action)
        {
            action();
        }

        private static void HouseAlarmDemo()
        {
            var house = new House();
            // Subscribing
            house.AlarmTrigerred += HouseOnAlarmTrigerred;
            // BEEP!
            house.Open();
        }

        private static void HouseOnAlarmTrigerred(object sender, AlarmTriggeredEventArgs e)
        {
            // If we want to use the sender info, we can by casting.
            var house = sender as House;
            Console.WriteLine("BEEP @" + e.TimeFired);
        }

        public class House
        {
            // Event without context.
            public event EventHandler<AlarmTriggeredEventArgs> AlarmTrigerred;
            public void Open()
            {
                // Sender is the object that fired the event.
                // In most cases we will refer it using this.
                // Passing context as well- event args.
                AlarmTrigerred?.Invoke(this, new AlarmTriggeredEventArgs());
            }
        }

        public class AlarmTriggeredEventArgs : EventArgs
        {
            public DateTime TimeFired { get; }

            public AlarmTriggeredEventArgs()
            {
                TimeFired = DateTime.Now;
            }
        }

        private static void House_AlarmTriggered(object sender, EventArgs e) => Console.WriteLine("Hello");
    }
}
