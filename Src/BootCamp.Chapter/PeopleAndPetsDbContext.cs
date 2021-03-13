using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp.Chapter
{
    public class PeopleAndPetsDbContext : DbContext
    {
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }

        //public PeopleAndPetsDbContext(DbContextOptions<PeopleAndPetsDbContext> options) 
        //    : base(options)
        //{
        //}

        public PeopleAndPetsDbContext() : base(UseSqlite())
        {
        }

        private static DbContextOptions<PeopleAndPetsDbContext> UseSqlite()
        {
            var options = new DbContextOptionsBuilder<PeopleAndPetsDbContext>()
                .UseSqlite(@"Data Source=d:\db\mydb.db;")
                .Options;

            return options;
        }
    }
}
