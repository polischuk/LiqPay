using System;
using System.Net;
using System.Security.Cryptography;
using LiqPay.Models;
using LiqPay.Models.Requests;
using LiqPay.Protocols;
using Xunit;

namespace LiqPay.Tests
{
    public class P2PLiqPayProtocolTests
    {
        readonly P2PLiqPayProtocol _protocol;
        public P2PLiqPayProtocolTests()
        {
            _protocol = new P2PLiqPayProtocol("your_private_key", "your_private_key");
        }

        [Fact]
        public void P2P_ShouldReturnOkResult()
        {
            //Act
            var result = _protocol.P2P(new P2PLiqPayRequestModel
            {
                Amount = 1,
                OrderId = Guid.NewGuid().ToString(),
                Card = "5398177075648209",
                Currency = Currency.UAH,
                Action = "p2p",
                CardExpMonth = "03",
                CardExpYear = "21",
                CardCvv = "111",
                ReceiverCard = "4485920066083382",
                Version = 3,
                Description = "test",
                Sandbox = "1"
            });
            //Assert
            Assert.NotNull(result);
            Assert.Same("sandbox", result.Status);
        }

        [Fact]
        public void Credit()
        {

            var orderId = Guid.NewGuid().ToString();
            var request = new P2PCreditLiqPayRequestModel()
            {
                Amount = 1,
                Currency = Currency.UAH,
                Description = "test",
                OrderId = orderId,
                ReceiverCard = "5398177075648209",
                Sandbox = "1",
                Ip = "127.0.0.1"
            };
            var result = _protocol.P2PCredit(request);
            Assert.Same("sandbox", result.Status);
        }
    }
}