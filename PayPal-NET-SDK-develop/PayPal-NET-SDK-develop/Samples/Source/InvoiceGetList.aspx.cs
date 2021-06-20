﻿using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayPal.Sample
{
    public partial class InvoiceGetList : BaseSamplePage
    {
        protected override void RunSample()
        {
            // ### Api Context
            // Pass in a `APIContext` object to authenticate 
            // the call and to send a unique request id 
            // (that ensures idempotency). The SDK generates
            // a request id if you do not pass one explicitly. 
            // See [Configuration.cs](/Source/Configuration.html) to know more about APIContext.
            var apiContext = Configuration.GetAPIContext();

            // ^ Ignore workflow code segment
            #region Track Workflow
            this.flow.AddNewRequest("Retrieve the list of recent invoices");
            #endregion

            // Retrieve the 10 most recent invoices and include the `total_count`
            var invoices = Invoice.GetAll(apiContext, pageSize: 10, totalCountRequired: true);

            // ^ Ignore workflow code segment
            #region Track Workflow
            this.flow.RecordResponse(invoices);
            #endregion

            // For more information, please visit [PayPal Developer REST API Reference](https://developer.paypal.com/docs/api/).
        }
    }
}