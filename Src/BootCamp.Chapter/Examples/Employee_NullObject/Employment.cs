using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Employee_NullObject
{
    public abstract class Employment
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employment(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
