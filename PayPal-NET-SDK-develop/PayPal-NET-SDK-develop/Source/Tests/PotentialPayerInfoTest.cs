﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;

namespace PayPal.Testing
{
    [TestClass]
    public class PotentialPayerInfoTest
    {
        public static readonly string PotentialPayerInfoJson =
            "{\"email\":\"test@example.com\"," +
            "\"external_remember_me_id\":\"1234\"," +
            "\"billing_address\":" + AddressTest.AddressJson + "}";

        public static PotentialPayerInfo GetPotentialPayerInfo()
        {
            return JsonFormatter.ConvertFromJson<PotentialPayerInfo>(PotentialPayerInfoJson);
        }

        [TestMethod, TestCategory("Unit")]
        public void PotentialPayerInfoObjectTest()
        {
            var testObject = GetPotentialPayerInfo();
            Assert.AreEqual("test@example.com", testObject.email);
			Assert.AreEqual("1234", testObject.external_remember_me_id);
			Assert.IsNotNull(testObject.billing_address);
        }

        [TestMethod, TestCategory("Unit")]
        public void PotentialPayerInfoConvertToJsonTest()
        {
            Assert.IsFalse(GetPotentialPayerInfo().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void PotentialPayerInfoToStringTest()
        {
            Assert.IsFalse(GetPotentialPayerInfo().ToString().Length == 0);
        }
    }
}
