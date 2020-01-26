// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
namespace BootCamp.Chapter
{
    internal class Program  // should be  public so the class can be used outside. Right now nobody can use it. 
    {
        private static void Main(string[] args) // should be public. Right now this function cannot be used outside the class 
        {
            // No using statement to System so Console is not known 
           //  No call to Lesson3.Demo so the user do not see the questions he/she excepted. 
            
            Console.WriteLine("Hello World!");
        }
    }
}
