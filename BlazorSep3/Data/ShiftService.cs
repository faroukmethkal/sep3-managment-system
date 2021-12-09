using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BlazorSep3.model;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorSep3.Data
{
    public class ShiftService:IShiftService
    {
        private HttpClient client;
        private readonly IJSRuntime jsonRuntime;

        public ShiftService(HttpClient client, IJSRuntime jsonRuntime)
        {
            this.client = client;
            this.jsonRuntime = jsonRuntime;
        }
        private async Task<Account> GetCurrentAccount()
        {
            string userAsJson = await jsonRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
            Account account = JsonConvert.DeserializeObject<Account>(userAsJson);
            return account;
        }

        public async Task<IList<Shift>> GetCriticalShifts()
        {
            List<Shift> result = new List<Shift>();
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + "api/criticalShifts"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Shift>>(message);
            
            return result;
        }

        public async Task AddShift(Shift shift)
        {
            if (string.IsNullOrEmpty(shift.Name)) throw new Exception("Enter tittle");
            if (string.IsNullOrEmpty(shift.Description)) throw new Exception("Enter description");

            string serializeShift = JsonConvert.SerializeObject(shift);
            Console.WriteLine(serializeShift);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeShift, Encoding.UTF8, "application/json"); 

            var response = await client.PostAsync(client.BaseAddress + "api/shift", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }
        

        public async Task<IList<Shift>> GetShifts(DateTime? date, DateTime? startTime, DateTime? endTime)
        {
            List<Shift> result = new List<Shift>();
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/shifts?date={date}&startTime={startTime}&endTime={endTime}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Shift>>(message);
            
            return result; 
        }
        
        public async Task<IList<Shift>> GetAllAvailableShift(DateTime? date, DateTime? startTime, DateTime? endTime)
        {
            List<Shift> result = new List<Shift>();
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/shifts?date={date}&startTime={startTime}&endTime={endTime}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Shift>>(message);
            
            return result; 
        }
        public async Task RemoveShift(int id)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);

            var response = await client.DeleteAsync(client.BaseAddress + $"api/shift?id={id}"); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task<Shift> GetShiftById(int id)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/shift?id={id}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
             Shift  shift = JsonConvert.DeserializeObject<Shift>(message);
            
            return shift; 
        }

        public async Task EditShift(Shift shift)
        {
            if (string.IsNullOrEmpty(shift.Name)) throw new Exception("Enter tittle");
            if (string.IsNullOrEmpty(shift.Description)) throw new Exception("Enter description");

            string serializeShift = JsonConvert.SerializeObject(shift);
            Console.WriteLine(serializeShift);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeShift, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + "api/shift", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
            
        }

        public async Task TakeShift(int id)
        {
            string serializeId = JsonConvert.SerializeObject(id);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeId, Encoding.UTF8, "application/json");
            HttpResponseMessage response = 
                await client.PutAsync(client.BaseAddress + 
                                      $"api/employee/shift?username={currentAccount.username}&Id={id}", content); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public Task AddParttimerToShift(int shiftId, string username)
        {
            throw new NotImplementedException();
        }

        public async Task UnassignFromShift(int id)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.DeleteAsync(client.BaseAddress + 
                                      $"api/employee/shift?username={currentAccount.username}&Id={id}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task<IList<Shift>> GetMyShifts(DateTime? date)
        {
            List<Shift> result = new List<Shift>();
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/myShifts?username={currentAccount.username}&date={date}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Shift>>(message);
            
            return result; 
        }
    }
}