using Newtonsoft.Json;

namespace LiqPay.Models.Requests.Acquiring
{
    public class HoldLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
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
        [JsonProperty("sandbox", NullValueHandling = NullValueHandling.Ignore)]
        public string Sandbox { get; set; }
        [JsonProperty("prepare", NullValueHandling = NullValueHandling.Ignore)]
        public string Prepare { get; set; }
        [JsonProperty("recurringbytoken", NullValueHandling = NullValueHandling.Ignore)]
        public string RecurringByToken { get; set; }
        [JsonProperty("server_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerUrl { get; set; }

        #region SenderParameters
        [JsonProperty("sender_first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderFirstName { get; set; }
        [JsonProperty("sender_last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderLastName { get; set; }
        [JsonProperty("sender_country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderCountryCode { get; set; }
        [JsonProperty("sender_city", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderCity { get; set; }
        [JsonProperty("sender_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderAddress { get; set; }
        [JsonProperty("sender_postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderPostalCode { get; set; }
        #endregion

        #region ReceiverParameters
        [JsonProperty("receiver_first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverFirstName { get; set; }
        [JsonProperty("receiver_last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverLastName { get; set; }
        #endregion

        #region 3DSParameters
        [JsonProperty("mpi_pares", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiPares { get; set; }
        [JsonProperty("mpi_md", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiMd { get; set; }
        #endregion

        #region OtherParameters
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public string Customer { get; set; }
        [JsonProperty("dae", NullValueHandling = NullValueHandling.Ignore)]
        public string Dae { get; set; }
        [JsonProperty("split_rules", NullValueHandling = NullValueHandling.Ignore)]
        public string SplitRules { get; set; }
        #endregion

    }
}
