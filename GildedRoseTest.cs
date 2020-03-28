using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }
        [Test]
        public void Should_Return_Zero_Quality_When_Current_Quality_Is_Equal_To_Zero_And_Item_Is_Not_AgedBrie_And_Not_Backstage_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality
                
                );
        }
        [Test]
        public void Should_Return_50_As_Quality_When_Current_Quality_Is_Equal_To_50_And_Item_Is_An_AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality

                );
        }
        [Test]
        public void Should_Return_50_As_Quality_When_Current_Quality_Is_Equal_To_50_And_Item_Is_A_Backstage_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality

                );
        }
        [Test]
        public void Should_Keep_The_Same_Quality_Value_When_The_Item_Is_Sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(40, Items[0].Quality);
        }
        [Test]
        public void Should_Increase_The_Quality_Value_When_The_Item_Is_AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(41, Items[0].Quality);
        }
        [Test]
        public void Should_Decrease_The_Quality_Value_When_The_Item_Is_Dexterity_Vest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(39, Items[0].Quality);
        }
        [Test]
        public void Should_Decrease_The_Quality_Value_When_The_Item_Is_Elixir_of_the_Mongoose()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 40 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(39, Items[0].Quality);
        }
    }
}
