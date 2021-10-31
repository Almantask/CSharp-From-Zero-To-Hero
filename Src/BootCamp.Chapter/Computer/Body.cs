using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public  class Body
    {
        public virtual void assembleBody()
        {
            Console.WriteLine("Install body");
        }
    }

    public class MsBody : Body
    {
        public MsBody()
        {
            assembleBody();
        }

        public override void assembleBody()
        {
            Console.WriteLine("Install Win Body");
        }

        public override string ToString()
        {
            return string.Format("Win Body");
        }
    }
    public class MacBody : Body
    {
        public MacBody()
        {
            assembleBody();
        }

        public override void assembleBody()
        {
            Console.WriteLine("Install Mac Body");
        }
    }
}
