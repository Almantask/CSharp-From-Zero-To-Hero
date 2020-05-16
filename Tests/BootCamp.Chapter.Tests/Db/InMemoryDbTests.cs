using System;
using BootCamp.Chapter.Examples.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BootCamp.Chapter.Tests.Db
{
    public class InMemoryDbTests : IDisposable
    {
        protected UsersContext Context { get; }

        public InMemoryDbTests()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            Context = new UsersContext(options);
        }

        public void Dispose()
        {
            // Sometimes is needed, not in this case in particular.
            // But better be safe than sorry :)
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }
    }
}
