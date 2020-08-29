using System.Threading.Tasks;
using BootCamp.Chapter.Examples.Employee_NullObject;
using BootCamp.Chapter.Examples.Shapes_Bridge;

namespace BootCamp.Chapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // PersonEmploymentDemo.Run();
            await ShapesExample.Run();
        }
    }
}
