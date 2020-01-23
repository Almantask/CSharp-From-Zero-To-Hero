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
        public string PromptString(String Message)
        {
            return Console.ReadLine();
        }

        public int PromptInt(String message)
        {
            return lesson3.ReadMyInput();
        }

        public float PromptFloat(String message)
        {
            return lesson3.AsFloat();
        }

        public float WhatIsTheBMI?()
        {
            return lesson3.EnterAndProcessBmiByHeightAndWeight();
        }
    }
}
