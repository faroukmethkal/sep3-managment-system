using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorSep3LoginExample.model;

namespace BlazorSep3LoginExample.Data
{
    public class ServiceUser : IServiceUser
    {
        private IHttpClientFactory httpClientFactory;

        public ServiceUser(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        

        public async Task<Dictionary<string, string>> ValidateUser(LoginUser user)
        {
            string serializedUser = JsonSerializer.Serialize(user);


            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "login");
            httpRequestMessage.Content = new StringContent(serializedUser);
            httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var client = httpClientFactory.CreateClient("UserService");
            
            var response = await client.SendAsync(httpRequestMessage);
            var responseStatusCode = response.StatusCode.ToString().ToLower();

            if (responseStatusCode.Equals("ok"))
            {
                var stringresponse = await response.Content.ReadAsStringAsync();
                Dictionary<string, string> values =
                    JsonSerializer.Deserialize<Dictionary<string, string>>(stringresponse);

                return values;
            }

            return null;
        }
    }
}