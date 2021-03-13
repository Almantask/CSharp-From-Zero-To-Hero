using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BootCamp.Chapter.Models
{
    [Table("Pets", Schema = "PP")]
    public class Pet
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
        // For advanced constraints- model builder.
    }
}
