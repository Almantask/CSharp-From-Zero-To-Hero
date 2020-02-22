using System;

namespace BootCamp.Chapter.V2
{
    // Every robot has a serial code
    class Robot
    {
        private string _name;
        private Head _head;
        private Legs _legs;

        public Robot()
        {
            _head = new Head("Beep bop", 10);
            _legs = new Legs("Autobots roll out!", 10);
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