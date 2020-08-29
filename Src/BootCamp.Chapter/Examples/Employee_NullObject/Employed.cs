using System;

namespace BootCamp.Chapter.Examples.Employee_NullObject
{
    public class Employed : Employment
    {
        public Employed(string name, decimal salary) : base(name, salary)
        {
            if (salary <= 0)
            {
                throw new Exception("Must be earning money");
            }
        }
    }
}