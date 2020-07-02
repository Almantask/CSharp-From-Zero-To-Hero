using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface IGridCaster<in TGrid> where TGrid : IToggleableGrid
    {
        void CastGrid(TGrid grid);
    }
}
