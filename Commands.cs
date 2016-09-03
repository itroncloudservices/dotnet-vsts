using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public static partial class Commands
    {
        public static async Task<JToken> AsJTokenAsync(this Task<HttpResponseMessage> requestAsync)
        {
            var response = await requestAsync;
            if (!response.IsSuccessStatusCode)
            {
                return await response.AsJTokenAsync();
            }

            var stringContent = await response.Content.ReadAsStringAsync();
            return JToken.Parse(stringContent);
        }

        public static Task<JToken> GetAsync(IConfiguration configuration)
        {
            Uri requestUri = null;
            using (var httpClient = NewHttpClient(configuration))
            {
                return httpClient
                    .GetAsync(requestUri)
                    .AsJTokenAsync();
            }
        }

        public static HttpClient NewHttpClient(IConfiguration configuration)
        {
            var client = new HttpClient();
            //client.BaseAddress = new Uri("", UriKind.Absolute);
            return client;
        }
    }
}