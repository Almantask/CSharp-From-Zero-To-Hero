using System;

namespace BootCamp.Chapter.Examples.UnsafeCode
{
    public class BufferOutOfBoundsException : Exception
    {
        public BufferOutOfBoundsException(int size, int maxSize) : base($"Buffer of size {maxSize} cannot take {size} characters.")
        {
        }
    }
}
