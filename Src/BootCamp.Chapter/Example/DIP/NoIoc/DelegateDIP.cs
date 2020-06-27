namespace BootCamp.Chapter.Example.DIP.NoIoc
{
    public class MyServiceClassicalDelegateDip
    {
        private readonly Write _writer;

        public MyServiceClassicalDelegateDip(Write writer)
        {
            _writer = writer;
        }
    }

    public class MyServiceClassicalDip
    {
        private readonly IWriter _writer;

        public MyServiceClassicalDip(IWriter writer)
        {
            _writer = writer;
        }
    }

    public interface IWriter
    {
        void Write(string text);
    }

    public delegate void Write(string text);
}
