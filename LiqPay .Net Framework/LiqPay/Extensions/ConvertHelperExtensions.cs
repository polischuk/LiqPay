using Newtonsoft.Json;

namespace LiqPay.Extensions
{
    public static class ConvertHelperExtensions
    {
        public static string ToJson(this object obj)
        {
            var result = JsonConvert.SerializeObject(obj);
            return result;
        }
    }
}