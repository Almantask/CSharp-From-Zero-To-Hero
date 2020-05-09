using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public class Chicken
    {
        public enum State
        {
            Stable,
            Scared,
            Hungry,
            Stuck
        }

        public Vector3 Location { get; private set; }
        public State CurrentState { get; private set; }

        public Chicken(State state, Vector3 location)
        {
            CurrentState = state;
            Location = location;
        }

        public void MoveForward(float speed)
        {
           
        }
    }
}
