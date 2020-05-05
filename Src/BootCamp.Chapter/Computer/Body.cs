using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class Body : Component
    {
        private CaseDesign _design;
        public CaseDesign GetDesign()
        {
            return _design;
        }

        public Body(string id, string manufacturer, string modelName, CaseDesign design) : base (id, manufacturer, modelName)
        {
            _design = design;
        }
    }

    public enum CaseDesign
    {
        ATX,
        EATX,
        Micro_ATX,
        Mini_DTX,
        Mini_ITX
    }
}
