using System;

namespace BootCamp.Chapter.Examples.UserMenu.v2
{
    public class UserMenu
    {
        private readonly IUserPrompt _prompt;

        public UserMenu(IUserPrompt userPrompt)
        {
            _prompt = userPrompt;
        }

        public void Display()
        {
            _prompt.WriteLine($"Menu options:{Environment.NewLine}" +
                              $"1) Display items{Environment.NewLine}" +
                              $"2) Display users{Environment.NewLine}");
            
            var input = _prompt.ReadLine();
            if (input == "1")
            {
                _prompt.WriteLine("Items");
                // Do a lot more...
            }
            else if (input == "2")
            {
                _prompt.WriteLine("Users");
                // Do a lot more...
            }
        }
    }
}
