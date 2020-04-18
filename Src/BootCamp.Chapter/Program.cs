using System.Globalization;
using System.Linq;
using System.Threading;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
            var handler = ArgumentsHandler.Create(args);
            handler.Execute();
        }
    }
}
