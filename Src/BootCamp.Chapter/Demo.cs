using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Models;

namespace BootCamp.Chapter
{
    public static class Demo
    {
        public static void AddTwoPeople()
        {
            var person1 = new Person()
            {
                Name = "Tom",
                BirthDay = DateTime.Now,
                Height = 170,
                Weight = 80.05f
            };

            var person2 = new Person()
            {
                Name = "Jack",
                BirthDay = DateTime.Now,
                Height = 179,
                Weight = 79.11f
            };

            using var context = new PeopleAndPetsDbContext();
            context.People.Add(person1);
            context.People.Add(person2);
            context.SaveChanges();
        }

        public static void AddTwoPetsToOwner()
        {
            var pet1 = new Pet()
            {
                BirthDay = DateTime.Now,
                Name = "Pukis"
            };

            var pet2 = new Pet()
            {
                BirthDay = DateTime.Now,
                Name = "Murka"
            };

            using var context = new PeopleAndPetsDbContext();
            var owner = context.People.FirstOrDefault(p => p.Id == 1);
            owner.Pets.Add(pet1);
            owner.Pets.Add(pet2);
            context.SaveChanges();
        }

        public static void SetRandomOwnerToPet()
        {
            var pet = new Pet()
            {
                Name = "Pett",
                BirthDay = DateTime.Now,
                PersonId = new Random().Next(1,3)
            };

            using var context = new PeopleAndPetsDbContext();
            context.Pets.Add(pet);
            context.SaveChanges();
        }
    }
}
