

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.JSInterop;



namespace BlazorSep3LoginExample.Authentication
{
    public class CustomAuthenticationStateProvider : ServerAuthenticationStateProvider
    {
        private readonly IJSRuntime _jsRuntime;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<string> GetTokenAsync()
        {
            string token =  await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "token");
            
            return token;

        }
        
        

        public async Task SetTokenAsync(string token)
        {
            if (token == null)
            {
                await _jsRuntime.InvokeAsync<string>("sessionStorage.removeItem", "token");
            }
            else
            {
                await _jsRuntime.InvokeAsync<string>("sessionStorage.setItem", "token", token);
            }
        }
        
    }
}