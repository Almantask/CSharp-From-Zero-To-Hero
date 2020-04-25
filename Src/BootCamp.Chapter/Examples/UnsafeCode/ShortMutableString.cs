#pragma warning disable 649

namespace BootCamp.Chapter.Examples.UnsafeCode
{
    /// <summary>
    /// Mutable string of up to 128 chars long.
    /// </summary>
    unsafe struct ShortMutableString
    {
        private const int BufferSize = 128;
        
        // fixed requires an array to be declared with a size (and doesn't need to be initialized).
        // fixed array also has no guards, no boundary checks and in case of out of bounds exceptions..
        // .. well there won't be any exceptions, it will just corrupt the memory.
        // It is also on stack and no GC will be needed.
        // The problems: every time you create something, you reserve a certain range in memory...
        // ...fixed means it won't be GC'ed, means it won't be defragmented...
        // ...this leads to running out of ram faster and thus fixed should be kept to a minimum.
        private fixed char _fixedBuffer[BufferSize];

        public char this[int index]
        {
            get
            {
                ValidateBounds(index);
                return _fixedBuffer[index];
            }
            set
            {
                ValidateBounds(index);
                _fixedBuffer[index] = value;
            }
        }

        public static implicit operator ShortMutableString(string text) => new ShortMutableString(text);
        public static implicit operator string(ShortMutableString text) => text.ToString();

        public ShortMutableString(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            ValidateBounds(text.Length);

            for (var index = 0; index < text.Length; index++)
            {
                var character = text[index];
                _fixedBuffer[index] = character;
            }
        }

        public void Replace(char character, int index)
        {
            ValidateBounds(index);
            _fixedBuffer[index] = character;
        }

        public override string ToString()
        {
            fixed(char* p = _fixedBuffer)
            {
                return new string(p);
            }
        }

        private static void ValidateBounds(int index)
        {
            if (index >= BufferSize || index < 0)
            {
                throw new BufferOutOfBoundsException(index, BufferSize);
            }
        }
    }
}
