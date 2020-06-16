using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples
{
    public abstract class GoodWorker
    {
        public virtual void WorksGreat()
        {
            Console.WriteLine("Works great!");
        }

        public abstract void Hope();
    }

    public class YikesWorker : GoodWorker
    {
        public override void WorksGreat()
        {
            throw new Exception("Crap");
        }

        public override void Hope()
        {
            Console.WriteLine("At least I got this one right");
        }
    }

    public class CompleteMessWorker : YikesWorker
    {
        public override void Hope()
        {
            throw new Exception("No hope");
        }
    }
}
