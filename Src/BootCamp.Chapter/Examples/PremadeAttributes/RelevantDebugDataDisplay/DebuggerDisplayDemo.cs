namespace BootCamp.Chapter.Examples.PremadeAttributes.RelevantDebugDataDisplay
{
    public static class DebuggerDisplayDemo
    {
        public static void Run()
        {
            var dummy1 = new Dummy
            {
                X1 = "First dummy",
                X2 = "second",
                X3 = "third",
                X4 = "forth",
                X5 = "fifth",
                X6 = "sixth",
                X7 = "seventh"
            };

            var dummy2 = new DummyWithToString
            {
                X1 = "Second dummy",
                X2 = "second",
                X3 = "third",
                X4 = "forth",
                X5 = "fifth",
                X6 = "sixth",
                X7 = "seventh"
            };

            var dummy3 = new DummyWithDisplay
            {
                X1 = "Third dummy",
                X2 = "second",
                X3 = "third",
                X4 = "forth",
                X5 = "fifth",
                X6 = "sixth",
                X7 = "seventh"
            };
        }
    }
}
