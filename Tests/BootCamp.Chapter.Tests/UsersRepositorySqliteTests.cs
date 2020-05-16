using System.Linq;
using BootCamp.Chapter.Examples.DataAccess;
using BootCamp.Chapter.Tests.Db;
using FluentAssertions;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class UsersRepositorySqliteTests : SqliteDbTests
    {
        private readonly UsersRepository _repo;

        public UsersRepositorySqliteTests()
        {
            _repo = new UsersRepository(Context);
        }

        [Fact]
        public void Create_When_AnyName_AddsUser()
        {
            var name = It.IsAny<string>();

            _repo.Create(name);

            Context.Users.Where(u => u.Name == name)
                .Should().NotBeNull();
        }

        [Fact]
        public void Get_Given_UserByThatIdExists_ReturnsUser()
        {
            const long id = 1;
            Context.Users.Add(new User() {Id = id });

            var user = _repo.Get(id);

            user.Should().NotBeNull();
        }
    }
}
