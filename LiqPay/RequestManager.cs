using Newtonsoft.Json;
using RestSharp;

namespace LiqPay
{
    public abstract class RequestManager
    {
        protected virtual IRestResponse PostRequest(string url, string data)
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST);
            request.AddParameter("application/json; charset=utf-8", data, ParameterType.RequestBody);
            // execute the request
            var response = client.Execute(request);
            return response;
        }

        protected virtual IRestResponse PostRequestWithData(string url, object data)
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST);
            request.AddObject(data);
            // execute the request
            var response = client.Execute(request);
            return response;
        }

        protected virtual IRestResponse<T> PostRequestWithData<T>(string url, object data, int timeout = 30000) where T : new()
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST, timeout);
            request.AddObject(data);
            // execute the request
            var response = client.Execute<T>(request);
            return response;
        }

        protected virtual IRestResponse<T> PostRequest<T>(string url, string data) where T : new()
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST);
            if (!string.IsNullOrWhiteSpace(data))
            {
                request.AddParameter("application/json; charset=utf-8", data, ParameterType.RequestBody);
            }
            // execute the request
            var response = client.Execute<T>(request);
            return response;
        }

        protected virtual IRestResponse<T> PostRequest<T>(string url, object data) where T : new()
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST);

            if (data != null)
            {
                request.AddParameter("application/json; charset=utf-8", data, ParameterType.RequestBody);
            }
            // execute the request
            var response = client.Execute<T>(request);
            return response;
        }

        protected virtual IRestResponse PostRequest(string url, object data)
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.POST);
            var json = JsonConvert.SerializeObject(data);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            // execute the request
            var response = client.Execute(request);
            return response;
        }

        protected virtual IRestResponse GetRequest(string url)
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.GET);
            // execute the request
            var response = client.Execute(request);
            return response;
        }

        protected virtual IRestResponse<T> GetRequest<T>(string url) where T : new()
        {
            var client = new RestClient(url);
            var request = CreateRestRequest(Method.GET);
            // execute the request
            var response = client.Execute<T>(request);
            return response;
        }

        private static RestRequest CreateRestRequest(Method method, int timeout = 30000)
        {
            var request = new RestRequest
            {
                Method = method,
                RequestFormat = DataFormat.Json,
                Timeout = timeout
            };
            return request;
        }
    }
}
