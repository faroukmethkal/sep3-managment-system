using System.Net.Http;
using System.Threading.Tasks;
using BlazorSep3.model;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorSep3.Data
{
    public class TaskServices : ITaskServices
    {
        private HttpClient client;
        private readonly IJSRuntime jsonRuntime;

        public TaskServices(HttpClient client, IJSRuntime jsonRuntime)
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
        
        
    }
}