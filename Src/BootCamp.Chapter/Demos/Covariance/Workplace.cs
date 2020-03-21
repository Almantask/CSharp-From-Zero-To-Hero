using System;
using System.Collections.Generic;
using BootCamp.Chapter.Demos.Common;
using BootCamp.Chapter.Demos.Contravariance;

namespace BootCamp.Chapter.Demos.Covariance
{
    // Workplace has employees. From a workplace we can get an existing employee by id.
    // We OUTPUT employee, therefore it's out.
    // out means covariance. It means that employee that we get can be generalized upon get.
    public interface IWorkplace<out TEmployee> where TEmployee : Employee
    {
        TEmployee GetEmployeeById(Guid id);
    }

    public interface IDivision<out TEmployee> : IWorkplace<TEmployee> where TEmployee : Employee
    {
    }

    public abstract class Division<TEmployee> : IDivision<TEmployee> where TEmployee : Employee
    {
        private readonly List<TEmployee> _employees;

        public Division(List<TEmployee> employees)
        {
            _employees = employees;
        }

        public TEmployee GetEmployeeById(Guid id)
        {
            foreach (var f in _employees)
            {
                if (f.Id == id) return f;
            }

            return null;
        }
    }

    public class FullstackDevsDivision : Division<FullstackDev>
    {
        public FullstackDevsDivision(List<FullstackDev> employees) : base(employees)
        {
        }
    }

    public class GameDevsDivision : Division<GameDev>
    {
        public GameDevsDivision(List<GameDev> employees) : base(employees)
        {
        }
    }

    public class ProgrammersDivision : Division<Programmer>
    {
        public ProgrammersDivision(List<Programmer> employees) : base(employees)
        {
        }
    }

    public class GlobalDevDivision : IDivision<Programmer>
    {
        // Due to division being covariance,
        // we can register all types that derive from IDivision<Programmer>.
        private List<IDivision<Programmer>> _divisions = new List<IDivision<Programmer>>(); 

        public void RegisterDivision(IDivision<Programmer> division)
        {
            _divisions.Add(division);
        }

        public Programmer GetEmployeeById(Guid id)
        {
            foreach (var division in _divisions)
            {
                // Generalization of specific programmer to programmer.
                // Valid- because of covariance.
                Programmer programmer = division.GetEmployeeById(id);
                if (programmer != null) return programmer;
            }

            return null;
        }
    }

}
