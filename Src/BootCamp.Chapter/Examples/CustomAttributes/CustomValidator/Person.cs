using System;

namespace BootCamp.Chapter.Examples.CustomAttributes.CustomValidator
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        
        [Required("A person must have a birthday.")]
        public DateTime? Birthday { get; set; }
        
        public bool IsSingle { get; set; }
    }
}
