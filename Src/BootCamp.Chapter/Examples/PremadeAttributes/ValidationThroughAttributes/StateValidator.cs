using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootCamp.Chapter.Examples.PremadeAttributes.ValidationThroughAttributes
{
    public static class StateValidator
    {
        public static void Validate(object obj)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(obj, null, null);
            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
