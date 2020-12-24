using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Subject
    {
        List<string> subjectArray = new List<string> { "Maths", "Art","PE","Music","English","Programming" };
    }
    class Math : Subject
    {
        public Math()
        { 
            Console.WriteLine($"welcome to Math lesson");
        }
    }
    class PE : Subject
    {
        public PE()
        {
            Console.WriteLine($"welcome to PE lesson");
        }
    }
}
