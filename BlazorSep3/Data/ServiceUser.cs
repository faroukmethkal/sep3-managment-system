using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorSep3.model;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorSep3.Data
{
    public class ServiceUser : IServiceUser
    {
        private HttpClient client;
        private readonly IJSRuntime jsonRuntime;

        public ServiceUser(HttpClient client, IJSRuntime jsonRuntime)
        {
            this.client = client;
            this.jsonRuntime = jsonRuntime;
        }


        private async  Task<Account> GetCurrentAccount()
        {
            string userAsJson = await jsonRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
            Account account = JsonConvert.DeserializeObject<Account>(userAsJson);
            return account;
        }

        public async Task<Account> ValidateUser(string username, string password)
        {
            Account returnUser = new Account();
            string Returnedtoken;
            string Returnedusername;
            string Returnedrole = null;

            LoginUser user = new LoginUser
            {
                username = username,
                password = password
            };

            string serializedUser = JsonConvert.SerializeObject(user);

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "login");
            httpRequestMessage.Content = new StringContent(serializedUser);
            httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            

            var response = await client.SendAsync(httpRequestMessage);
            var responseStatusCode = response.StatusCode.ToString().ToLower();

            if (responseStatusCode.Equals("ok"))
            {
                var stringresponse = await response.Content.ReadAsStringAsync();
                Dictionary<string, string> values =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(stringresponse);

                if (values.TryGetValue("access_token", out Returnedtoken))
                    if (values.TryGetValue("role", out Returnedrole))
                        if (values.TryGetValue("username", out Returnedusername))

                            returnUser.username = Returnedusername;
                returnUser.Token = Returnedtoken;
                returnUser.Role = Returnedrole;

                return returnUser;
            }

            throw new Exception(responseStatusCode.ToString());
        }

        public async Task RegisterUser(Profile profile)
        {
            if (string.IsNullOrEmpty(profile.FirstName)) throw new Exception("Enter first name");
            if (string.IsNullOrEmpty(profile.LastName)) throw new Exception("Enter last name");
            if (string.IsNullOrEmpty(profile.Specialities)) throw new Exception("Enter specialities");
            if (string.IsNullOrEmpty(profile.Role.ToString())) throw new Exception("Enter role");

            string serializedProfile = JsonConvert.SerializeObject(profile);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializedProfile, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(client.BaseAddress + "api/profile", content);
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }
    }
}