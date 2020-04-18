namespace BootCamp.Chapter
{
    internal class CommandArgument
    {
        public CommandArgument(string argument)
        {
            Argument = argument;
        }

        public string Argument { get; }
        public string NormalizedArgument => Argument.ToUpperInvariant();
    }
}
