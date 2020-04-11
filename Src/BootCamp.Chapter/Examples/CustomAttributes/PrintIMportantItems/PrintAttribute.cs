using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.PrintIMportantItems
{
    // Print attribute can be applied everywhere.
    // It can also be used multiple times on the same target.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class PrintAttribute : Attribute
    {
        public string Message { get; }

        public PrintAttribute(string message)
        {
            Message = message;
        }
    }
}
