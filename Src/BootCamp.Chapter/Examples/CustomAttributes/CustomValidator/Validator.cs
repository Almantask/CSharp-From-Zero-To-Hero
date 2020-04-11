using System;
using System.Linq;

namespace BootCamp.Chapter.Examples.CustomAttributes.CustomValidator
{
    public static class Validator
    {
        public static void Validate(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var prop in properties)
            {
                var requiredAttribute = AttributesGetter.GetPropertyAttribute<RequiredAttribute>(prop);
                if (requiredAttribute == null) continue;

                var value = prop.GetValue(obj);
                if (value == null)
                {
                    Console.WriteLine(string.IsNullOrEmpty(requiredAttribute.Error)
                        ? $"{prop.Name} field is required."
                        : requiredAttribute.Error);
                }
            }
        }
    }
}
