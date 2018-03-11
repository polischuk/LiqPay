using LiqPay.Contracts;
using LiqPay.Models.Requests;
using LiqPay.Models.Responses;

namespace LiqPay.Protocols
{
    public class P2PLiqPayProtocol : BaseLiqPayProtocol, IP2PLiqPayProtocol
    {
        public P2PLiqPayProtocol(string publicKey, string privateKey) : base(publicKey, privateKey)
        {
        }

        public P2PLiqPayResponseModel P2P(P2PLiqPayRequestModel model)
        {
            model.Action = "p2p";
            return SendQuery<P2PLiqPayRequestModel, P2PLiqPayResponseModel>(model);
        }
        public P2PCreditLiqPayResponseModel P2PCredit(P2PCreditLiqPayRequestModel model)
        {
            model.Action = "p2pcredit";
            return SendQuery<P2PCreditLiqPayRequestModel, P2PCreditLiqPayResponseModel>(model);
        }
    }
}
