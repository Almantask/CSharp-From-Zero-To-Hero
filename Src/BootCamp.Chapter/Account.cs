using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Account
    {
        public Account(string name, string password)
        {
            Name = name;
            Password = Encoding.Unicode.GetBytes(password);
        }
        public string Name { get; }
        public byte[] Password { get; }
    }
}
