using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class AuthLiqPayRequestModel: BaseLiqPayRequestModel
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("card_exp_month")]
        public string CardExpMonth { get; set; }

        [JsonProperty("card_exp_year")]
        public string CardExpYear { get; set; }

        [JsonProperty("card_cvv")]
        public string CardCvv { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        #region 3DS parameters
        [JsonProperty("mpi_pares", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiPares { get; set; }

        [JsonProperty("mpi_md", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiMd { get; set; }
        #endregion

        #region Other parameters
        [JsonProperty("verifycode", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyCode { get; set; }

        [JsonProperty("suburl", NullValueHandling = NullValueHandling.Ignore)]
        public string SubUrl { get; set; }
        #endregion
    }
}
