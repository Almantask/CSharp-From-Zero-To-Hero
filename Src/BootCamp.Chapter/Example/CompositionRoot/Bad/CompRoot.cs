using System;
using Microsoft.Extensions.DependencyInjection;
namespace BootCamp.Chapter.Example.CompositionRoot.Bad
{
    class CompRoot
    {
        public class MainWindow
        {
            private readonly IServiceProvider _serviceProvider;
  
            public MainWindow(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
            }

            public void OnButtonToolsClick()
            {
                _serviceProvider.GetService<ToolsForm>();
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
