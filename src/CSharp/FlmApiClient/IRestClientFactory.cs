using RestSharp;
using System.Collections.Generic;

namespace FlmApiClient
{
    public interface IRestClientFactory
    {
        /// <summary>
        /// The default headers to apply to each request
        /// </summary>
        List<KeyValuePair<string, string>> DefaultHeaders { get; }

        /// <summary>
        /// Creates a new rest client
        /// </summary>
        /// <returns>IRestClient</returns>
        IRestClient CreateClient();

        /// <summary>
        /// Creates a new rest client
        /// </summary>
        /// <param name="baseUrl">The default url</param>
        /// <returns>IRestClient</returns>
        IRestClient CreateClient(string baseUrl);

        /// <summary>
        ///  Creates a new request object that can be executed by a client
        /// </summary>
        /// <param name="method"> Method to use for this request</param>
        /// <returns>IRestRequest</returns>
        IRestRequest CreateRequest(string route, Method method);

        /// <summary>
        ///  Creates a new request object that can be executed by a client
        /// </summary>
        /// <param name="route">The route to apply to the base host</param>
        /// <param name="method"> Method to use for this request</param>
        /// <param name="xmlBody">Apply the xml body to the request</param>        
        /// <returns>IRestRequest</returns>
        IRestRequest CreateRequest(string route, Method method, string xmlBody);
    }
}
