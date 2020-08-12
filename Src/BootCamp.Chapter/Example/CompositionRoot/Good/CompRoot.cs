using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Example.CompositionRoot.Good
{
    class CompRoot
    {
        public class MainWindow
        {
            private readonly IToolsDisplayer _toolsdisplayer;
  
            public MainWindow(IToolsDisplayer toolsDisplayer)
            {
                _toolsdisplayer = toolsDisplayer;
            }

            public void OnButtonToolsClick()
            {
                _toolsdisplayer.Display();
            }
        }

        public interface IToolsDisplayer
        {
            void Display();
        }

        public class ToolsDisplayer : IToolsDisplayer
        {
            private readonly IFoo _foo;
            private readonly IBar _bar;

            public void Display() => new ToolsForm(_foo, _bar);
        }
    }

    internal interface IFoo
    {
    }

    internal interface IBar
    {
    }

    internal class ToolsForm
    {
        private IFoo _foo;
        private IBar _bar;

        public ToolsForm(IFoo foo, IBar bar)
        {
            _foo = foo;
            _bar = bar;
        }
    }
}
