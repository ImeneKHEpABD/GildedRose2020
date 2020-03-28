﻿using NUnit.Framework;
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
        [TestCase("Elixir of the Mongoose", 40, 39)]
        [TestCase("+5 Dexterity Vest", 40, 39)]
        public void Should_Decrease_The_Quality_Value_When_The_Item_Is_Not_AgedBrie_And_Not_BackStage_Passes_And_Not_Sulfuras_The_Sell_By_Date_Has_Passed(string itemName, int ItemQuality, int ItemExpectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = itemName, SellIn = 10, Quality = ItemQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(ItemExpectedQuality, Items[0].Quality);
        }
        [TestCase("Elixir of the Mongoose", 40, 38)]
        [TestCase("+5 Dexterity Vest", 40, 38)]
        public void Should_Increase_The_Quality_Value_Twice_When_The_Item_Is_Not_AgedBrie_And_Not_BackStage_Passes_And_The_Sell_By_Date_Has_Passed(string itemName, int ItemQuality, int ItemExpectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = itemName, SellIn = -1, Quality = ItemQuality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(ItemExpectedQuality, Items[0].Quality);
        }

    }
}
