using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public class MpiLiqPayResponseModel : BaseLiqPayResponseModel
    {
        [JsonProperty("mpi_req_pareq")]
        public string MpiReqPareq { get; set; }

        [JsonProperty("mpi_req_md")]
        public string MpiReqMd { get; set; }

        [JsonProperty("mpi_req_url")]
        public string MpiReqUrl { get; set; }

        [JsonProperty("mpi_status")]
        public string MpiStatus { get; set; }
    }
}
