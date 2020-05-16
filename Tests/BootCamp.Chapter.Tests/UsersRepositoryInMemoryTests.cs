using System.Linq;
using BootCamp.Chapter.Examples.DataAccess;
using BootCamp.Chapter.Tests.Db;
using FluentAssertions;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class UsersRepositoryInMemoryTests : InMemoryDbTests
    {
        private readonly UsersRepository _repo;

        public UsersRepositoryInMemoryTests()
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
        public void Get_Given_UserByThatIdExists_Returns_User()
        {
            const long id = 1;
            Context.Users.Add(new User() {Id = id });

            var user = _repo.Get(id);

            user.Should().NotBeNull();
        }

        [Fact]
        public void Get_Given_UserByThatIdDoesNotExist_Returns_Null()
        {
            const long id = 2;
            Context.Users.Add(new User() { Id = 1 });

            var user = _repo.Get(id);

            user.Should().BeNull();
        }
    }
}
