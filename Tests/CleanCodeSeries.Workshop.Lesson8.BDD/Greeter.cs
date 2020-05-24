using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeSeries.Workshop.Lesson8.BDD
{
    public class Greeter
    {
        public Language Language { set; private get; }

        private readonly IDictionary<Language, string> _greetings;

        public Greeter()
        {
            _greetings = new Dictionary<Language, string>()
            {
                {BDD.Language.EN, "Hello"},
                {BDD.Language.LT, "Labas"}
            };
        }

        public string Greet(string name)
        {
            return $"{_greetings[Language]}, {name}!";
        }
    }
}
