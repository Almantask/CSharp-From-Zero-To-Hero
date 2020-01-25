// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
namespace BootCamp.Chap
{
    class Checks
    {
        public string PromptString(String Message) // this must be string because you want the type string not the class string.
        {
           // No using statement for System so Console is unknown.
           // No call to the own function so it is not testable. 
            return Console.ReadLine(); 
        }

        public int PromptInt(String message) // this must be string because you want the type string not the class string.
        {
            // Lesson3 must be written with a capital first character because you want to use the class Lesson3. 
            lesson3.ReadMyInput();
        }

        public float PromptFloat(String message) // this must be string because you want the type string not the class string.
        {
            // Lesson3 must be written with a capital first character because you want to use the class Lesson3. 
            return lesson3.AsFloat();
        }

        public float WhatIsTheBMI?() // in the name a ? is illigal not the compiler thinks that a tuple should be used 
        //  There is a space between the name and the curly braces. The curly braces must be  diret after the name 
        {
             // Lesson3 must be written with a capital first character because you want to use the class Lesson3.
             // and the function does not exist which is called. 
            return lesson3.EnterAndProcessBmiByHeightAndWeight();
        }
    }
}
