using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class ReportLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("date_from")]
        public string DateFrom { get; set; }
        [JsonProperty("date_to")]
        public string DateTo { get; set; }
    }
}
