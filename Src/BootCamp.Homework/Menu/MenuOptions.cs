using System.Collections.Generic;

namespace BootCamp.Homework.Menu
{
    public class MenuOptions
    {
        public Dictionary<Options, string> Labels { get; } = new Dictionary<Options, string>
        {
            {Options.Grid2d, "Toggleable 2d Grid"},
            {Options.GridJagged, "Toggleable Jagged Grid"},
            {Options.CommonLetter, "Most Common Letter Finder"},
            {Options.Exit, "Exit"}
        };
    }
    
    public enum Options
    {
        Grid2d,
        GridJagged,
        CommonLetter,
        Exit
    }
}