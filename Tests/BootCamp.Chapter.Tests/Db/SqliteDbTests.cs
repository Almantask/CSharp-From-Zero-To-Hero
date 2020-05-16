using System;
using System.Data.Common;
using BootCamp.Chapter.Examples.DataAccess;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BootCamp.Chapter.Tests.Db
{
    public class SqliteDbTests : IDisposable
    {
        protected UsersContext Context { get; }
        private readonly DbConnection _connection;

        public SqliteDbTests()
        {
            var options = new DbContextOptionsBuilder<UsersContext>()
                .UseSqlite(CreateInMemoryDatabase())
                .Options;
            
            Context = new UsersContext(options);
            _connection = RelationalOptionsExtension.Extract(options).Connection;
        }

        private static DbConnection CreateInMemoryDatabase()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();

            return connection;
        }

        public void Dispose() => _connection.Dispose();
    }
}
