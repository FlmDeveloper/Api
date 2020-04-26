using RestSharp;

namespace FlmApiClient
{
    public interface IFlmClient
    {
        /// <summary>
        /// Gets a response from an endpoint
        /// </summary>
        /// <returns>string</returns>
        string GetResponse(string route);
    }
}
