using System;
using LiqPay.Models.Requests;
using LiqPay.Models.Responses;

namespace LiqPay.Contracts
{
    public interface IBaseLiqPayProtocol
    {
        StatusLiqPayResponseModel GetStatus(StatusLiqPayRequestModel model);
        OtpVerifyLiqPayResponseModel OtpVerify(OtpVerifyLiqPayRequestModel model);
        Verify3DsLiqPayResponseModel Verify3Ds(Verify3DsLiqPayRequestModel model);
    }
}