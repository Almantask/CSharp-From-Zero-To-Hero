using BootCamp.Chapter.Examples.Animals;
using BootCamp.Chapter.Examples.Family;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class TalkTests
    {
        [Fact]
        public void AnimalTalk_Returns_Empty()
        {
            var animal = new Animal();

            var words = animal.Talk();

            Assert.Equal("", words);
        }

        [Fact]
        public void CatTalk_Returns_Expected()
        {
            var animal = new Cat();

            var words = animal.Talk();

            Assert.Equal("Meow", words);
        }

        [Fact]
        public void LionTalk_Returns_Expected()
        {
            var animal = new Lion();

            var words = animal.Talk();

            Assert.Equal("Rawr", words);
        }

        [Fact]
        public void WolfTalk_Returns_Expected()
        {
            var animal = new Wolf();

            var words = animal.Talk();

            Assert.Equal("Auuuuuuuuuuuu", words);
        }
    }
}
