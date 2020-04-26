using static Newtonsoft.Json.JsonConvert;
using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlmApiClient
{
    public class FlmClient : IFlmClient
    {
        private readonly string _baseUri = "https://api.fieldlevelmedia.com:443/v1";
        private readonly IRestClientFactory _restClientFactory;

        #region Init
        public FlmClient(
            IRestClientFactory restClientFactory,
            Guid apiKey)
        {
            _restClientFactory = restClientFactory ?? throw new ArgumentNullException(nameof(restClientFactory));
            var flmToken = GetApiToken(apiKey) ?? throw new ArgumentException($"Invalid token {apiKey}");
            restClientFactory.DefaultHeaders.Add(
                 new KeyValuePair<string, string>("Authorization", $"Bearer {flmToken.Token}"));

            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

        }
        #endregion

        /// <summary>
        /// Gets a response from an endpoint
        /// </summary>
        /// <returns>IRestResponse</returns>
        public string GetResponse(string route)
        {
            var response = _restClientFactory.CreateClient(_baseUri).Execute(
                                _restClientFactory.CreateRequest(route, Method.GET));

            return response.IsSuccessful
                    ? JValue.Parse(response.Content).ToString(Formatting.Indented)
                    : response.Content;
        }

        /// <summary>
        /// Gets a Flm Token that can be used to authenticate client requests
        /// </summary>
        /// <param name="apiKey">The ApiKey assigned to a client from field Level Media</param>
        /// <returns>ApiToken</returns>
        private ApiToken GetApiToken(Guid apiKey)
        {
            try
            {
                var request = _restClientFactory.CreateRequest("/Token", Method.POST);
                request.AddParameter("ApiKey", apiKey);
                var response = _restClientFactory.CreateClient(_baseUri).Execute(request);

                return response.IsSuccessful
                        ? DeserializeObject<ApiToken>(response.Content)
                        : null;
            }
            catch { }

            return null;
        }
    }
}
