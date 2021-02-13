using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Builder.Problems
{
    public class Gift
    {
        public string Content { get; set; }
        public string Recipient { get; set; }
        // could more things

        public override string ToString() => Content;
    }
}
