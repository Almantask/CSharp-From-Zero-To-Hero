using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public abstract class Component
    {
        private string _id;
        public string GetID()
        {
            return _id;
        }

        private string _manufacturer;
        public string GetManufacturer()
        {
            return _manufacturer;
        }

        private string _modelName;
        public string GetModelName()
        {
            return _modelName;
        }

        protected Component(string componentID, string manufacturer, string modelName)
        {
            _id = componentID;
            _manufacturer = manufacturer;
            _modelName = modelName;
        }
    }
}
