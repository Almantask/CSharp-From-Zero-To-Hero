using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Demos.Common;

namespace BootCamp.Chapter.Demos.Covariance
{
    public static class CovarianceDemo
    {
        public static void Run()
        {
            var dev = new FullstackDev();
            var id = dev.Id;

            IDivision<Programmer> programmersDivision = new ProgrammersDivision(new List<Programmer>());
            IDivision<FullstackDev> fullstackDivision = new FullstackDevsDivision(new List<FullstackDev>() { dev });
            IDivision<GameDev> gamedevDivision = new GameDevsDivision(new List<GameDev>());
            
            GlobalDevDivision globalDevDivision = new GlobalDevDivision();
            globalDevDivision.RegisterDivision(programmersDivision);
            globalDevDivision.RegisterDivision(fullstackDivision);
            globalDevDivision.RegisterDivision(gamedevDivision);

            var employee = globalDevDivision.GetEmployeeById(id);
            Console.WriteLine(employee?.Id.ToString() ?? "Not found");
        }
    }
}
