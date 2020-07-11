using System;
using System.Reflection;

namespace BootCamp.Chapter
{
    class ApplicationController
    {
        // implement into a method that invokes this event and has the termination logic tirggered?
        public event EventHandler<ApplicationModeEventArgs> ApplicationModeChanged;
        public IInputMonitor<ConsoleKey> InputMonitor { get; }

        private readonly Filters Filters = new Filters();

        // Passing the instatiated IInputMonitor object such that the correct event is called in method InitializeApplication()
        public ApplicationController(IInputMonitor<ConsoleKey> inputMonitor)
        {
            InputMonitor = inputMonitor;
        }

        /// <summary>
        /// Changes mode to APPLICATION_STARTED: Starts the application and continually checks for User Keyboard Inputs at Main Menu
        /// </summary>
        private void InitializeApplication()
        {
            ChangeMode(ApplicationModes.APPLICATION_STARTED);
            while (true)
            {
                InputMonitor.MonitorInput(MainMenuInput());
            }       
        }

        /// <summary>
        /// Chnages mode to DEMO_STARTED: Runs the pre-created Demo
        /// </summary>
        private void StartDemo()
        {
            ChangeMode(ApplicationModes.DEMO_STARTED);
            Demo demo = new Demo();
            demo.DemoParserAndFilter();
            EndDemo();
        }

        /// <summary>
        /// Changes mode to DEMO_ENDED: Called when the Demo ends
        /// </summary>
        private void EndDemo()
        {
            ChangeMode(ApplicationModes.DEMO_ENDED);
        }

        /// <summary>
        /// Changes mode to APPLICATION_CLOSED: Called when User ends application. Triggers action with method OnCloseApplicationRequest()
        /// </summary>
        private void CloseApplication()
        {
            ChangeMode(ApplicationModes.APPLICATION_CLOSED);
        }

        /// <summary>
        /// Runs the Application
        /// </summary>
        public void Run()
        {
            InitializeApplication();
            CloseApplication();
        }

        // Subscriber to ApplicationModeChange
        public void OnApplicationModeChange(object sender, ApplicationModeEventArgs e)
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{sender.GetType().Name}: changing Application Mode to {e.Mode}");
            Console.ResetColor();
        }

        // Subscriber to ApplicationModeChange. Specifically listens for Mode 'APPLICATION_CLOSED'. Unsubscribes all subscriptions to the events.
        public void OnCloseApplicationRequest(object sender, ApplicationModeEventArgs e)
        {
            if (e.Mode == ApplicationModes.APPLICATION_CLOSED)
            {
                ApplicationModeChanged -= OnApplicationModeChange;
                ApplicationModeChanged -= OnCloseApplicationRequest;
                InputMonitor.InputPressed -= OnInputPressed;
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Invokes EventHandler 'ApplicationModeChanged' provide it IS NOT null
        /// </summary>
        /// <param name="newMode"></param>
        private void ChangeMode(ApplicationModes newMode) 
        {
            ApplicationModeChanged?.Invoke(this, new ApplicationModeEventArgs(newMode));
        }

        // Subscriber to InputPressed
        public void OnInputPressed(object sender, InputPressedEventArgs<ConsoleKey> e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"User Input Registered: [{e.Input}]");
            Console.ResetColor();
            ModeInitialization(e.Input);
        } 

        
        private void ModeInitialization(ConsoleKey input) 
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    StartDemo();
                    return;

                case ConsoleKey.A:
                    Filters.FilterA();
                    return;

                case ConsoleKey.B:
                    Filters.FilterB();
                    return;

                case ConsoleKey.C:
                    Filters.FilterC();
                    return;

                case ConsoleKey.Escape:
                    CloseApplication();
                    return;

                default:
                    Console.WriteLine("Please select one the of the options stated! Please try again.");
                    return;
            }
        }
        
        private ConsoleKey MainMenuInput()
        {
            Console.WriteLine("Application Menu\n------------");
            Console.WriteLine("Please select one of the following options:\n");
            Console.WriteLine("1 - Start Demo");
            Console.WriteLine("A - FilterA: IsA");
            Console.WriteLine("B - FilterB: IsB");
            Console.WriteLine("C - FilterC: IsC");
            Console.WriteLine("ESC - Close Application");

            return Console.ReadKey(true).Key;
        }
    }
}
