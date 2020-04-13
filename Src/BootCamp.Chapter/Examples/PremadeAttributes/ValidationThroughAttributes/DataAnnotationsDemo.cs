using System;

namespace BootCamp.Chapter.Examples.PremadeAttributes.ValidationThroughAttributes
{
    public static class DataAnnotationsDemo
    {
        public static void Run()
        {
            var person1 = new Person()
            {
                Name = "k'c",
            };

            var person2 = new Person()
            {
                Name = " 'g",
                Birthday = DateTime.Now,
                Email = "gg@gmail.com"
            };

            var person3 = new Person()
            {
                Name = "Tara",
                Birthday = DateTime.Now,
                Email = "gggmail.com"
            };

            var person4 = new Person()
            {
                Name = "444a9x'",
            };

            var person5 = new Person()
            {
                // 60 symbols (max allowed is 40)
                Name = "ajsdlkajdl" +
                       "kdjlkasdjs" +
                       "ldkajsdlka" +
                       "jdlkdjlkas" +
                       "djsldkajsd" +
                       "lkajdlkdjl"
            };

            StateValidator.Validate(person1);
            StateValidator.Validate(person2);
            StateValidator.Validate(person3);
            StateValidator.Validate(person4);
            StateValidator.Validate(person5);
        }
    }
}
