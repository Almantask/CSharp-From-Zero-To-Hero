﻿using System;

namespace BootCamp.Chapter.Computer
{
    public class Motherboard
    {
        public Motherboard()
        {

        }

        public virtual void assembleMotherboard()
        {
            Console.WriteLine("Install Motherboard");
        }
    }

    public class MsMotherBoard : Motherboard
    {
        public MsMotherBoard()
        {
            assembleMotherboard();
        }

        public override void assembleMotherboard()
        {
            Console.WriteLine("Install Win Motherboard");
        }
    }
    public class MacMotherBoard : Motherboard
    {
        public MacMotherBoard()
        {
            assembleMotherboard();
        }

        public override void assembleMotherboard()
        {
            Console.WriteLine("Install Mac Motherboard");
        }
    }
}