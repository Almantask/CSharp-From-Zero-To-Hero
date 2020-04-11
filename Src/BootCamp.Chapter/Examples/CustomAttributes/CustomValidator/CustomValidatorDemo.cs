using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.CustomValidator
{
    public static class CustomValidatorDemo
    {
        public static void Run()
        {
            var people = new[]
            {
                new Person
                {
                    Name = "Tom"
                },

                new Person
                {
                    Birthday = DateTime.Now
                },

                new Person
                {
                    IsSingle = false
                },

                new Person
                {
                    Name = "Kai",
                    Birthday = new DateTime(1994, 5, 25),
                    IsSingle = true // :(
                }
            };

            foreach (var person in people)
            {
                Validator.Validate(person);
            }
        }
    }
}
