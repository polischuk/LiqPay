using System;
using LiqPay.Models.Requests;
using LiqPay.Models.Requests.Acquiring;
using LiqPay.Models.Responses;
using LiqPay.Models.Responses.Acquiring;

namespace LiqPay.Contracts
{
    public interface IAcquirerLiqPayProtocol : IBaseLiqPayProtocol
    {
        HoldLiqPayResponseModel Hold(HoldLiqPayRequestModel model);
        HoldCompletionLiqPayResponseModel HoldCompletion(HoldCompletionLiqPayRequestModel model);
        PayLiqPayResponseModel Pay(PayLiqPayRequestModel model);
        SubscribeLiqPayResponseModel Subscribe(SubscribeLiqPayRequestModel model);
        UnsubscribeLiqPayResponseModel Unsubscribe(UnsubscribeLiqPayRequestModel model);
        MpiLiqPayResponseModel Mpi(MpiLiqPayRequestModel model);
        AcquirerLiqPayResponseModel Refund(RefundLiqPayRequestModel model);
        ReportLiqPayResponseModel Reports(DateTime dateFrom, DateTime dateTo);
        AuthLiqPayResponseModel Auth(AuthLiqPayRequestModel model);
    }
}