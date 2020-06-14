using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Renderer
{
    interface IGridRenderer<in TGrid> where TGrid : IToggleableGrid
    {
        void Render(TGrid grid);
    }
}
