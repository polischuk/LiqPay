# LiqPay
Privatbank LiqPay protocol  on dotnet core and .net framework

# Usage
Install from the package manager console:
```
    PM> Install-Package PrivatBank.LiqPay 
```

# P2PLiqPayProtocol
## P2P
```cs
var protocol = new P2PLiqPayProtocol("your_private_key", "your_private_key");
var result = protocol.P2P(new P2PLiqPayRequestModel
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
```
## P2P credit
```cs
  var orderId = Guid.NewGuid().ToString();
  var protocol = new P2PLiqPayProtocol("your_private_key", "your_private_key");
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
  var result = protocol.P2PCredit(request);
```
