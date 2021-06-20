﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;

namespace PayPal.Testing
{
    /// <summary>
    /// Summary description for MerchantInfoTest
    /// </summary>
    [TestClass]
    public class MerchantInfoTest
    {
        public static readonly string MerchantInfoJson =
            "{\"email\":\"jziaja.test.merchant-facilitator@gmail.com\"," +
            "\"first_name\":\"Dennis\"," +
            "\"last_name\":\"Doctor\"," +
            "\"business_name\":\"Medical Professionals, LLC\"," +
            "\"phone\":" + PhoneTest.PhoneJson + "," +
            "\"address\":" + InvoiceAddressTest.InvoiceAddressJson + "}";

        public static MerchantInfo GetMerchantInfo()
        {
            return JsonFormatter.ConvertFromJson<MerchantInfo>(MerchantInfoJson);
        }

        [TestMethod, TestCategory("Unit")]
        public void MerchantInfoObjectTest()
        {
            var testObject = GetMerchantInfo();
            Assert.AreEqual("jziaja.test.merchant-facilitator@gmail.com", testObject.email);
            Assert.AreEqual("Dennis", testObject.first_name);
            Assert.AreEqual("Doctor", testObject.last_name);
            Assert.AreEqual("Medical Professionals, LLC", testObject.business_name);
            Assert.IsNotNull(testObject.phone);
            Assert.IsNotNull(testObject.address);
        }

        [TestMethod, TestCategory("Unit")]
        public void MerchantInfoConvertToJsonTest()
        {
            Assert.IsFalse(GetMerchantInfo().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void MerchantInfoToStringTest()
        {
            Assert.IsFalse(GetMerchantInfo().ToString().Length == 0);
        }
    }
}
