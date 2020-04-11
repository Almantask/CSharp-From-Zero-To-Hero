using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.CustomValidator
{
    [Obsolete("Use DataAnnotations.RequiredAttribute instead.")]
    public sealed class RequiredAttribute : Attribute
    {
        public string Error { get; }

        public RequiredAttribute(string error = "")
        {
            Error = error;
        }
    }
}
