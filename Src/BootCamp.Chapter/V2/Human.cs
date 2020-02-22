using System;

namespace BootCamp.Chapter.V2
{
    class Human
    {
        private string _name;
        private Head _head;
        private Legs _legs;

        public Human()
        {
            _head = new Head("Bla bla bla", 10);
            _legs = new Legs("Step step step", 10);
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public void Talk()
        {
            _head.Talk();
        }
        public void Walk()
        {
            _legs.Walk();
        }
    }
}