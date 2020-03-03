using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        public virtual DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();
            var body = new Body("a  standard body");
            computer.SetBody(body); 

            return computer; 
        
        }
            
    }
}
