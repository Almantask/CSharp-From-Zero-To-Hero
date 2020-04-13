using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.CustomValidator
{
    [Obsolete("Use DataAnnotations.RequiredAttribute instead.")]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class RequiredAttribute : Attribute
    {
        public string Error { get; }

        public RequiredAttribute(string error = "")
        {
            Error = error;
        }
    }
}
