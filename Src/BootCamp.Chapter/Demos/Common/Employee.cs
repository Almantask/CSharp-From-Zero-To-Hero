using System;

namespace BootCamp.Chapter.Demos.Common
{
    public class Employee
    {
        public Guid Id { get; }

        public Employee()
        {
            Id = Guid.NewGuid();
        }

        public Employee(Guid id)
        {
            Id = id;
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }

    public class Janitor : Employee
    {
    }

    public class Programmer : Employee
    {
    }

    public class GameDev : Programmer
    {
    }

    public class BackendDev : Programmer
    {
    }

    public class FullstackDev : Programmer
    {
    }
}