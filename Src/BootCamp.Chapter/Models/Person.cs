using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BootCamp.Chapter.Models
{
    [Table("People", Schema = "PP")]
    public class Person
    {
        public Person()
        {
            Pets = new List<Pet>();
        }

        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        // TODO: constraint inside model builder
        public DateTime BirthDay { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public IList<Pet> Pets { get; set; }
    }
}
