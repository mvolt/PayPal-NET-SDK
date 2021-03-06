//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class NameValuePair : PayPalSerializableObject
    {
        /// <summary>
        /// Key for the name value pair.  The value name types should be correlated 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string name { get; set; }

        /// <summary>
        /// Value for the name value pair.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value")]
        public string value { get; set; }
    }
}
