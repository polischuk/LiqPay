using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public abstract class BaseLiqPayResponseModel
    {
        [JsonProperty("err_code")]
        public string ErrCode { get; set; }
        [JsonProperty("err_description")]
        public string ErrDescription { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
