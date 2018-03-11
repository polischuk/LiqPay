using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public abstract class BaseLiqPayRequestModel
    {
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonIgnore]
        public string PrivateKey { get; set; }
    }
}
