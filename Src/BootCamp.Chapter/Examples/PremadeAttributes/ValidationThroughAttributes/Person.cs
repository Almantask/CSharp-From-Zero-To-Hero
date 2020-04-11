using System;
using System.ComponentModel.DataAnnotations;

namespace BootCamp.Chapter.Examples.PremadeAttributes.DataAnnotations
{
    public class Person
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z'\s]{1,40}$")]
        public string Name { get; set; }

        [RequiredAttribute]
        public DateTime? Birthday { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public float Weight { get; set; }
    }
}
