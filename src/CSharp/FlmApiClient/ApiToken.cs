using Newtonsoft.Json;


namespace FlmApiClient
{
    public class ApiToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
