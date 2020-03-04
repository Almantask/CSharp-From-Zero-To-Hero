using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class Body
    {
        private string _manufacturersId;
        public Body(string manufacturersId)
        {
            _manufacturersId = manufacturersId;
        }

        public string GetManufacturersId()
        {
            return _manufacturersId;
        }
    }
}
