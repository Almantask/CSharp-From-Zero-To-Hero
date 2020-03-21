using System;
using BootCamp.Chapter.Demos.Common;

namespace BootCamp.Chapter.Demos.Contravariance
{
    // Supports casting to a more specific TEmployee when passing to as input.
    interface IManager<in TEmployee> where TEmployee : Employee
    {
        void Manage(TEmployee employee);
    }

    class EmployeeManager<TEmployee> : IManager<TEmployee> where TEmployee : Employee
    {
        public void Manage(TEmployee employee)
        {
            Console.WriteLine("Do work in general!");
            employee.Work();
        }
    }


    class ProgrammersManager<TProgrammer> : IManager<TProgrammer> where TProgrammer : Programmer
    {
        public void Manage(TProgrammer employee)
        {
            Console.WriteLine("Do programming!");
            employee.Work();
        }
    }

    class JanitorsManager<TJanitor> : IManager<TJanitor> where TJanitor : Janitor
    {
        public void Manage(TJanitor employee)
        {
            Console.WriteLine("Do cleaning!");
            employee.Work();
        }
    }
}
