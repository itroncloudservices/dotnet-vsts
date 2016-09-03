using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Microsoft.VisualStudio.Services.Contrib.Tools
{
    public static class Errors
    {
        public static async Task<JToken> AsJTokenAsync(this HttpResponseMessage response) =>
            new JObject(
                new JProperty("content", await response.Content.ReadAsStringAsync()),
                new JProperty("method", response.RequestMessage.Method),
                new JProperty("requestUri", response.RequestMessage.RequestUri),
                new JProperty("statusCode", (int)response.StatusCode),
                new JProperty("reasonPhrase", response.ReasonPhrase)
                );
    }
}
