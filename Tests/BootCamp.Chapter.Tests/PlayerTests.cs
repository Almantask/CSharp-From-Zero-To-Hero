using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PlayerTests
    {
        private readonly Player _player;

        public PlayerTests()
        {
            _player = new Player("Test Name");
        }

        [Fact]
        public void AddItem_Adds_New_Item_In_Inventory()
        {
            var item = new Item("Potion", 20, 0.2f);

            _player.AddItem(item);
            var items = _player.GetItems(item.Name);


            items.Should().Contain(item);
        }

        [Fact]
        public void RemoveItem_Given_Item_Exists_Removes_Item_From_Inventory_By_Item_Values()
        {
            var item = new Item("Sword", 10, 5);
            _player.AddItem(item);

            _player.Remove(item);

            var items = _player.GetItems(item.Name);
            
            items.Should().NotContain(item);
        }

        [Fact]
        public void RemoveItem_Given_Item_Does_Not_Exist_Ignores()
        {
            var item = new Item("Sword", 10, 5);
            
            Action action = () => _player.Remove(item);
            
            action.Should().NotThrow();
        }

        [Fact]
        public void Add_Item_Given_Item_Is_Null_Throws_ArgumentNullException()
        {
            Action action = () => _player.AddItem(null);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Remove_Item_Given_Item_Is_Null_Throws_ArgumentNullException()
        {
            Action action = () => _player.Remove(null);

            action.Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void GetItems_Given_ItemName_Is_Null_Or_Empty_Throws_ArgumentException(string item)
        {
            Action action = () => _player.GetItems(item);

            // modification made to make the checked error to be 'ArgumentNullException' rather than previous 'ArgumentException'
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
