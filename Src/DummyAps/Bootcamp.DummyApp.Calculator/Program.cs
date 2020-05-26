using System;
using System.Windows.Forms;
using CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk;

namespace Bootcamp.DummyApp.Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorView());
        }
    }
}
