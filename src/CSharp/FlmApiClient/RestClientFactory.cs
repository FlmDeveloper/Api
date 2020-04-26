using System.Collections.Generic;
using RestSharp;

namespace FlmApiClient
{
    public class RestClientFactory : IRestClientFactory
    {
        #region IRestClientFactory
        /// <summary>
        /// The default headers to apply to each request
        /// </summary>
        public List<KeyValuePair<string, string>> DefaultHeaders { get; private set; } =
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("cache-control", "keep-alive"),
                new KeyValuePair<string, string>("connection", "no-cache"),
                new KeyValuePair<string, string>("Accept-Encoding", "gzip, deflate"),
                new KeyValuePair<string, string>("Accept", "*/*"),
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
            };

        /// <summary>
        /// Creates a new rest client
        /// </summary>
        /// <returns>IRestClient</returns>
        public IRestClient CreateClient() => new RestClient();

        /// <summary>
        /// Creates a new rest client
        /// </summary>
        /// <param name="baseUrl">The default url</param>
        /// <returns>IRestClient</returns>
        public IRestClient CreateClient(string baseUrl) => new RestClient(baseUrl);

        /// <summary>
        /// Creates a new request object that can be executed by a client
        /// </summary>
        /// <param name="route">The route to apply to the base host</param>
        /// <param name="method"> Method to use for this request</param>
        /// <returns>IRestRequest</returns>        
        public IRestRequest CreateRequest(string route, Method method)
            => CreateRequest(route, method, null);

        /// <summary>
        /// Creates a new request object that can be executed by a client
        /// </summary>
        /// <param name="route">The route to apply to the base host</param>
        /// <param name="method"> Method to use for this request</param>
        /// <param name="xmlBody">Apply the xml body to the request</param>        
        /// <returns>IRestRequest</returns>
        public IRestRequest CreateRequest(
            string route,
            Method method,
            string xmlBody)
        {
            var request = new RestRequest(route);
            request.Method = method;
            request.Timeout = 25000;

            foreach (var header in DefaultHeaders)
            {
                request.AddHeader(header.Key, header.Value);
            }

            if (!string.IsNullOrWhiteSpace(xmlBody))
            {
                request.AddHeader("Content-Length", xmlBody.Length.ToString());
                request.AddParameter("undefined", xmlBody, ParameterType.RequestBody);
            }

            return request;
        }
        #endregion
    }
}
