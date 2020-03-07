using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class ComputerCase
    {
        private string _manufacturersId;
        public ComputerCase(string manufacturersId)
        {
            _manufacturersId = manufacturersId;
        }

        public string GetManufacturersId()
        {
            return _manufacturersId;
        }
    }
}
