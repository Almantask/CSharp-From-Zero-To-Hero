using System;

namespace BootCamp.Homework.Menu
{
    public class MainMenu
    {
        private readonly InteractiveMenu _menu = new InteractiveMenu();
        private readonly GridMenu _gridMenu = new GridMenu();
        private readonly CommonLetterMenu _commonLetter = new CommonLetterMenu();
        
        public void DisplayMenu()
        {
            var menuOption = _menu.Build();
            Console.Clear();
            
            if (menuOption == Options.Grid2d) _gridMenu.DisplayGrid2dMenu();
            if (menuOption == Options.GridJagged) _gridMenu.DisplayGridJaggedMenu();
            if (menuOption == Options.CommonLetter) _commonLetter.DisplayCommonLetterMenu();
        }
    }
}