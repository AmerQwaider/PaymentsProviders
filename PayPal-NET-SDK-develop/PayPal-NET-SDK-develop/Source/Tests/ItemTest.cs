﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;

namespace PayPal.Testing
{
    [TestClass()]
    public class ItemTest
    {
        public static readonly string ItemJson =
            "{\"name\":\"Item Name\"," +
            "\"currency\":\"USD\"," +
            "\"price\":\"10\"," +
            "\"quantity\":\"5\"," +
            "\"sku\":\"Sku\"}";

        public static Item GetItem()
        {
            return JsonFormatter.ConvertFromJson<Item>(ItemJson);
        }

        [TestMethod, TestCategory("Unit")]
        public void ItemObjectTest()
        {
            var itm = GetItem();
            Assert.AreEqual(itm.name, "Item Name");
            Assert.AreEqual(itm.currency, "USD");
            Assert.AreEqual(itm.price, "10");
            Assert.AreEqual(itm.quantity, "5");
            Assert.AreEqual(itm.sku, "Sku");
        }

        [TestMethod, TestCategory("Unit")]
        public void ItemConvertToJsonTest()
        {
            Assert.IsFalse(GetItem().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void ItemToStringTest()
        {
            Assert.IsFalse(GetItem().ToString().Length == 0);
        }
    }
}
