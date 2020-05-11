using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.InvoiceIssuer;
using Moq;

namespace BootCamp.Chapter.Tests
{
    public interface IPeoplesRepository
    {
        IEnumerable<Person> Get();
    }

    class Class1
    {
        public void Test()
        {
            var peoplesRepository = Mock.Of<IPeoplesRepository>();
            var system = new Sut(peoplesRepository);

            var peoplesRepositoryMock = new Mock<IPeoplesRepository>();
            peoplesRepositoryMock.Setup(repo => repo.Get())
                .Returns(new List<Person>());

            peoplesRepositoryMock.Verify(repo => repo.Get(), Times.Once);
        }
    }

    internal class Sut
    {
        public Sut(IPeoplesRepository peoplesRepository)
        {
            throw new NotImplementedException();
        }
    }
}
