using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public  class Body
    {
        public Body()
        {
            
        }

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
    }


}
