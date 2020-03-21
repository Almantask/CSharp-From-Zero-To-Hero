using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Demos.Common;

namespace BootCamp.Chapter.Demos.Contravariance
{
    class ContravarianceDemo
    {
        public static void Run()
        {
            IManager<Janitor> janitorsManager = new JanitorsManager<Janitor>();
            IManager<Programmer> programmersManager = new ProgrammersManager<Programmer>();
            IManager<Employee> employeeManager = new EmployeeManager<Employee>();

            // EmployeeManager is not a JanitorsManager.
            // However both work, because EmployeeManager can take EVERY employee.
            // So this means that we can store all the managers,
            // as long as they accept Janitors or more generalized forms.
            IManager<Janitor>[] managers = {janitorsManager, employeeManager};
            
            // Therefore the name- contravariance. Because it goes a bit against common sense.
            // Contra, meaning the opposite, we normally generalize things and not specify them more
            // when working in polymorphic/generic context.

            foreach (var manager in managers)
            {
                // All Janitors are Employes but not the other way round.
                // Therefore EmployeeManager handles Janitor just fine as well.
                // And for the same reason we cannot pass a generalization of Janitor.
                // Because JanitorManager won't be able to handle it.
                manager.Manage(new Janitor());
            }
        }
    }
}
