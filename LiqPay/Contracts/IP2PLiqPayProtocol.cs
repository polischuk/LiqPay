using LiqPay.Models.Requests;
using LiqPay.Models.Responses;

namespace LiqPay.Contracts
{
    public interface IP2PLiqPayProtocol : IBaseLiqPayProtocol
    {
        P2PLiqPayResponseModel P2P(P2PLiqPayRequestModel model);
        P2PCreditLiqPayResponseModel P2PCredit(P2PCreditLiqPayRequestModel model);
    }
}