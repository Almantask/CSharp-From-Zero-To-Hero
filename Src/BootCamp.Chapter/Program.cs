using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // part1 
            var contents = File.ReadAllLines(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input/Balances.corrupted");
            foreach (var line in contents)
            {
                var repairedText = line.ToString().Replace("_", "");
                repairedText += Environment.NewLine; 
                File.AppendAllText(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input/Balances.repaired", repairedText);

            }
            
                    
        }
    }
}
