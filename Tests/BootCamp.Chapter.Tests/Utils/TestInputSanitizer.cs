using System;

namespace BootCamp.Chapter.Tests.Utils
{
    public static class TestInputSanitizer
    {
        public static string ToNewlineSentences(this string message) => message.Replace(".", $".{Environment.NewLine}");
    }
}