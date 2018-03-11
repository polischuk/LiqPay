using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiqPay.Models.Responses
{
    public abstract class BasePaymentLiqPayResponseModel : BaseLiqPayResponseModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("err_erc")]
        public string ErrErc { get; set; }
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        [JsonProperty("acq_id")]
        public int AcqId { get; set; }
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("liqpay_order_id")]
        public string LiqpayOrderId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("sender_phone")]
        public string SenderPhone { get; set; }
        [JsonProperty("sender_card_mask2")]
        public string SenderCardMask2 { get; set; }
        [JsonProperty("sender_card_bank")]
        public string SenderCardBank { get; set; }
        [JsonProperty("sender_card_country")]
        public int SenderCardCountry { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("customer")]
        public string Customer { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public string Currency { get; set; }
        [JsonProperty("sender_commission")]
        public decimal SenderCommission { get; set; }
        [JsonProperty("receiver_commission")]
        public decimal ReceiverCommission { get; set; }
        [JsonProperty("agent_commission")]
        public decimal AgentCommission { get; set; }
        [JsonProperty("amount_debit")]
        public int AmountDebit { get; set; }
        [JsonProperty("amount_credit")]
        public int AmountCredit { get; set; }
        [JsonProperty("commission_debit")]
        public decimal CommissionDebit { get; set; }
        [JsonProperty("commission_credit")]
        public decimal CommissionCredit { get; set; }
        [JsonProperty("currency_debit")]
        public string CurrencyDebit { get; set; }
        [JsonProperty("currency_credit")]
        public string CurrencyCredit { get; set; }
        [JsonProperty("sender_bonus")]
        public decimal SenderBonus { get; set; }
        [JsonProperty("amount_bonus")]
        public decimal AmountBonus { get; set; }
        [JsonProperty("refund_amount")]
        public decimal RefundAmount { get; set; }
        [JsonProperty("completion_date")]
        public string CompletionDate { get; set; }
        [JsonProperty("authcode_debit")]
        public string AuthcodeDebit { get; set; }
        [JsonProperty("authcode_credit")]
        public string AuthcodeCredit { get; set; }
        [JsonProperty("rrn_debit")]
        public string RrnDebit { get; set; }
        [JsonProperty("rrn_credit")]
        public string RrnCredit { get; set; }
        [JsonProperty("arrn_debit")]
        public string ArrnDebit { get; set; }
        [JsonProperty("arrn_credit")]
        public string ArrnCredit { get; set; }
        [JsonProperty("verifycode")]
        public string Verifycode { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("is_3ds")]
        public bool Is3Ds { get; set; }
    }
}
