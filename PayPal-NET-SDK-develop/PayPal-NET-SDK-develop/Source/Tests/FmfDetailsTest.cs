﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;

namespace PayPal.Testing
{
    [TestClass()]
    public class FmfDetailsTest
    {
        public static readonly string FmfDetailsJson =
            "{\"filter_type\":\"FILTER\"," +
            "\"filter_id\":\"001\"," +
            "\"name\":\"Filter name\"," +
            "\"description\":\"Filter description\"}";

        public static FmfDetails GetFmfDetails()
        {
            return JsonFormatter.ConvertFromJson<FmfDetails>(FmfDetailsJson);
        }

        [TestMethod, TestCategory("Unit")]
        public void FmfDetailsObjectTest()
        {
            var testObject = GetFmfDetails();
            Assert.AreEqual("FILTER", testObject.filter_type);
            Assert.AreEqual("001", testObject.filter_id);
            Assert.AreEqual("Filter name", testObject.name);
            Assert.AreEqual("Filter description", testObject.description);
        }

        [TestMethod, TestCategory("Unit")]
        public void FmfDetailsConvertToJsonTest()
        {
            Assert.IsFalse(GetFmfDetails().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void FmfDetailsToStringTest()
        {
            Assert.IsFalse(GetFmfDetails().ToString().Length == 0);
        }
    }
}
