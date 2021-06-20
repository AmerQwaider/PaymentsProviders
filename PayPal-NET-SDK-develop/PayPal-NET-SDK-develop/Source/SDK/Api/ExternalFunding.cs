//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// A resource representing an external funding object.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class ExternalFunding : PayPalSerializableObject
    {
        /// <summary>
        /// Unique identifier for the external funding
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference_id")]
        public string reference_id { get; set; }

        /// <summary>
        /// Generic identifier for the external funding
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "code")]
        public string code { get; set; }

        /// <summary>
        /// Encrypted PayPal Account identifier for the funding account
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_account_id")]
        public string funding_account_id { get; set; }

        /// <summary>
        /// Description of the external funding being applied
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "display_text")]
        public string display_text { get; set; }

        /// <summary>
        /// Amount being funded by the external funding account
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Currency amount { get; set; }

        /// <summary>
        /// Indicates that the Payment should be fully funded by External Funded Incentive
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funding_instruction")]
        public string funding_instruction { get; set; }
    }
}
