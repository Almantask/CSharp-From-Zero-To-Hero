using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class ShopTests
    {
        private const string ItemName = "Shortsword";
        private const decimal ItemPrice = 10;
        private const decimal InitialShopMoney = 10;

        private Shop _shop;

        public ShopTests()
        {
            _shop = new Shop(InitialShopMoney);
        }

        [Fact]
        public void Add_New_Item_Adds_Item_To_Stock()
        {
            var sword = new Item(ItemName, ItemPrice, 2);
            _shop.Add(sword);

            _shop.GetItems().Should().Contain(sword);
        }

        [Fact]
        public void Add_New_Item_Twice_Adds_Item_New_Item_To_Stock_And_Ignores_Second()
        {
            var sword = new Item(ItemName, ItemPrice, 2);
            _shop.Add(sword);
            _shop.Add(sword);

            _shop.GetItems().Should().Contain(sword);
        }

        [Fact]
        public void Remove_Item_Given_Item_Of_The_Same_Name_Exists_Removes_That_Item()
        {
            var sword = new Item(ItemName, ItemPrice, 2);
            _shop.Add(sword);

            _shop.Remove(ItemName);
            
            _shop.GetItems().Should().NotContain(sword);
        }

        [Fact]
        public void Sell_Item_Given_Item_Exists_Returns_ItemSold_And_Adds_Sold_Item_Price_To_Shop_Money()
        {
            var sword = new Item(ItemName, ItemPrice, 2);
            _shop.Add(sword);

            var itemSold = _shop.Sell(ItemName);

            using (new AssertionScope())
            {
                itemSold.Should().Be(sword);
                _shop.GetMoney().Should().Be(InitialShopMoney + itemSold.GetPrice());
            }
        }

        [Fact]
        public void Buy_Item_Reduces_Shop_Money_By_The_Bought_Item_Price()
        {
            var sword = new Item(ItemName, ItemPrice, 2);
            
            var baughtItemPrice = _shop.Buy(sword);

            using (new AssertionScope())
            {
                baughtItemPrice.Should().Be(ItemPrice);
                _shop.GetMoney().Should().Be(InitialShopMoney - baughtItemPrice);
            }
        }

        [Fact]
        public void Buy_Item_Given_Shop_Does_Not_Have_Enough_Money_Returns_0_And_Does_Not_Change_Shops_Money()
        {
            // Sword that costs more than a shop has
            var sword = new Item(ItemName, InitialShopMoney + 1, 2);

            // Ignores buying- not enough money.
            var baughtItemPrice = _shop.Buy(sword);

            using (new AssertionScope())
            {
                baughtItemPrice.Should().Be(0);
                _shop.GetMoney().Should().Be(InitialShopMoney);
            }
        }
    }
}
