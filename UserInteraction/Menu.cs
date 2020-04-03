using System;
using UtilsLibrary;

namespace MenuLibrary
{
    public class MenuItem
    {
        public string Title { get; }
        public Action Execute { get; }
        public char Key { get; set; }

        public MenuItem(string title, Action execute, char key)
        {
            if (!Utils.IsValid(title) || execute is null || !Utils.IsValid(key))
            {
                throw new ArgumentNullException($"{nameof(title)}, {nameof(execute)} & {nameof(key)} can not be null or empty");
            }

            Title = title;
            Execute = execute;
            Key = key;
        }
    }
}