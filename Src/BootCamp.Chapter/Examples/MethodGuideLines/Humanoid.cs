using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.MethodGuideLines
{
    interface IHumanoid
    {
        void Talk(string words);
        void Walk();
    }

    class Person : IHumanoid
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }

        public void Talk(string words)
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

    static class HumanoidSimulation
    {
        //IHumanoid over person, because we just need to talk.
        public static void TalkTo(IHumanoid humanoid1, IHumanoid humanoid2)
        {
            humanoid1.Talk("bla bla");
            humanoid2.Talk("bla bla bla");
        }
    }
}
