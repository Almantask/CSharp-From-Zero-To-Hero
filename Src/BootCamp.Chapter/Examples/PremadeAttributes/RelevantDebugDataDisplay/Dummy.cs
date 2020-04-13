using System.Diagnostics;

namespace BootCamp.Chapter.Examples.PremadeAttributes.RelevantDebugDataDisplay
{
    [DebuggerDisplay("Relevant state: X1 = {X1}")]
    class DummyWithDisplay : DummyWithToString
    {
    }

    public class DummyWithToString: Dummy
    {
        public override string ToString() => X1 + X2 + X3 + X4 + X5 + X6 + X7;
    }

    public class Dummy
    {
        public string X1 { get; set; }
        public string X2 { get; set; }
        public string X3 { get; set; }
        public string X4 { get; set; }
        public string X5 { get; set; }
        public string X6 { get; set; }
        public string X7 { get; set; }
    }
}
