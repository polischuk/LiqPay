using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using LiqPay.Contracts;
using LiqPay.Extensions;
using LiqPay.Models.Requests;
using LiqPay.Models.Responses;

namespace LiqPay.Protocols
{
    public abstract class BaseLiqPayProtocol : RequestManager, IBaseLiqPayProtocol
    {
        protected readonly string PublicKey;
        protected readonly string BaseUrl = "https://www.liqpay.com/api/request";
        protected readonly string PrivateKey;
        private const int ApiVersion = 3;

        protected BaseLiqPayProtocol(string publicKey, string privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        protected virtual TResponse SendQuery<TRequest, TResponse>(TRequest model)
            where TRequest : BaseLiqPayRequestModel
            where TResponse : BaseLiqPayResponseModel, new()
        {
            if (model.PublicKey == null)
            {
                model.PublicKey = PublicKey;
            }

            model.Version = ApiVersion;
            var base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(model.ToJson()));
            var requestModel = new
            {
                data = base64String,
                signature = ComputeSignature(base64String, model.PrivateKey ?? PrivateKey)
            };
            var response = PostRequestWithData<TResponse>(BaseUrl, requestModel, 60000);
            return response.StatusCode == HttpStatusCode.OK
                ? response.Data
                : throw new HttpRequestException(response.StatusCode.ToString());
        }

        public virtual OtpVerifyLiqPayResponseModel OtpVerify(OtpVerifyLiqPayRequestModel model)
        {
            model.Action = "otp_verify";
            return SendQuery<OtpVerifyLiqPayRequestModel, OtpVerifyLiqPayResponseModel>(model);
        }
        public virtual Verify3DsLiqPayResponseModel Verify3Ds(Verify3DsLiqPayRequestModel model)
        {
            model.Action = "3ds_verify";
            return SendQuery<Verify3DsLiqPayRequestModel, Verify3DsLiqPayResponseModel>(model);
        }

        public virtual StatusLiqPayResponseModel GetStatus(StatusLiqPayRequestModel model)
        {
            model.Action = "status";
            return SendQuery<StatusLiqPayRequestModel, StatusLiqPayResponseModel>(model);
        }

        private string ComputeSignature(string postData, string password)
        {
            var str = password + postData + password;
            var sha1 = SHA1.Create();
            var sha1Res = sha1.ComputeHash(Encoding.UTF8.GetBytes(str));
            var sha1ResString = Convert.ToBase64String(sha1Res);
            return sha1ResString;
        }
    }
}