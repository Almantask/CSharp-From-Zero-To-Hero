using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.Shapes_Bridge.Shapes;

namespace BootCamp.Chapter.Examples.Shapes_Bridge.Animations
{
    public class MoveRight : IAnimation
    {
        private string _lastDrawn;

        // This is bad.
        public void AttachShape(IShape shape)
        {
            _lastDrawn = shape.Pattern;
        }

        public void Animate()
        {
            var lines = _lastDrawn.Split(Environment.NewLine);
            var sb = new StringBuilder();
            
            foreach (var line in lines)
            {
                sb.AppendLine(" " + line);
            }

            _lastDrawn = sb.ToString().TrimEnd();

            Console.WriteLine(_lastDrawn);
        }
    }
}
