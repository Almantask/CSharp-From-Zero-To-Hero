using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos.Constraints
{
    public static class ContraintsDemo
    {
        public static void DoSomethingForClass<T>() where T : class { }
    }
}
