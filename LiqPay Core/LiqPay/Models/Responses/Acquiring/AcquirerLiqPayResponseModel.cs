using Newtonsoft.Json;

namespace LiqPay.Models.Responses.Acquiring
{
    public class AcquirerLiqPayResponseModel : BasePaymentLiqPayResponseModel
    {
        [JsonProperty("product_url")]
        public string ProductUrl { get; set; }
        [JsonProperty("product_category")]
        public string ProductCategory { get; set; }
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }
    }
}
