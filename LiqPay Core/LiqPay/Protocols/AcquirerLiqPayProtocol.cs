using System;
using LiqPay.Contracts;
using LiqPay.Models.Requests;
using LiqPay.Models.Requests.Acquiring;
using LiqPay.Models.Responses;
using LiqPay.Models.Responses.Acquiring;

namespace LiqPay.Protocols
{
    public class AcquirerLiqPayProtocol : BaseLiqPayProtocol, IAcquirerLiqPayProtocol
    {
        public AcquirerLiqPayProtocol(string publicKey, string privateKey) : base(publicKey, privateKey)
        {
        }

        public virtual HoldLiqPayResponseModel Hold(HoldLiqPayRequestModel model)
        {
            model.Action = "hold";
            return SendQuery<HoldLiqPayRequestModel, HoldLiqPayResponseModel>(model);
        }

        public virtual HoldCompletionLiqPayResponseModel HoldCompletion(HoldCompletionLiqPayRequestModel model)
        {
            model.Action = "hold_completion";
            return SendQuery<HoldCompletionLiqPayRequestModel, HoldCompletionLiqPayResponseModel>(model);
        }

        public virtual PayLiqPayResponseModel Pay(PayLiqPayRequestModel model)
        {
            model.Action = "pay";
            model.RecurringByToken = "1";
            return SendQuery<PayLiqPayRequestModel, PayLiqPayResponseModel>(model);
        }

        public virtual SubscribeLiqPayResponseModel Subscribe(SubscribeLiqPayRequestModel model)
        {
            model.Action = "subscribe";
            return SendQuery<SubscribeLiqPayRequestModel, SubscribeLiqPayResponseModel>(model);
        }

        public virtual UnsubscribeLiqPayResponseModel Unsubscribe(UnsubscribeLiqPayRequestModel model)
        {
            model.Action = "unsubscribe";
            return SendQuery<UnsubscribeLiqPayRequestModel, UnsubscribeLiqPayResponseModel>(model);
        }
        
        public virtual MpiLiqPayResponseModel Mpi(MpiLiqPayRequestModel model)
        {
            model.Action = "mpi";
            return SendQuery<MpiLiqPayRequestModel, MpiLiqPayResponseModel>(model);
        }

        public virtual AcquirerLiqPayResponseModel Refund(RefundLiqPayRequestModel model)
        {
            model.Action = "refund";
            return SendQuery<RefundLiqPayRequestModel, AcquirerLiqPayResponseModel>(model);
        } 

        public virtual ReportLiqPayResponseModel Reports(DateTime dateFrom, DateTime dateTo)
        {
            ReportLiqPayRequestModel model = new ReportLiqPayRequestModel
            {
                Action = "reports",
                DateFrom = GetTimestamp(dateFrom),
                DateTo = GetTimestamp(dateTo)
            };
            return SendQuery<ReportLiqPayRequestModel, ReportLiqPayResponseModel>(model);
        }

        public virtual AuthLiqPayResponseModel Auth(AuthLiqPayRequestModel model)
        {
            model.Action = "auth";
            return SendQuery<AuthLiqPayRequestModel, AuthLiqPayResponseModel>(model);
        }

        private static string GetTimestamp(DateTime date)
        {
            var timeStamp =
                (long)date.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
            return timeStamp.ToString();
        }
    }
}