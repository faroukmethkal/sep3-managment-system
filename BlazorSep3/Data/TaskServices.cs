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
     public class TaskServices : ITaskServices
    {
        private HttpClient client;
        private readonly IJSRuntime jsonRuntime;

        public TaskServices(HttpClient client, IJSRuntime jsonRuntime)
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


        public async Task AddTask(Taskk task)
        {
            if (string.IsNullOrEmpty(task.Title)) throw new Exception("Enter tittle");
            if (string.IsNullOrEmpty(task.Description)) throw new Exception("Enter description");

            string serializedTask = JsonConvert.SerializeObject(task);
            Console.WriteLine(serializedTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializedTask, Encoding.UTF8, "application/json"); 

            var response = await client.PostAsync(client.BaseAddress + "api/tasks", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task<IList<Taskk>> GetTasks(DateTime? startTime, DateTime? deadLine, bool?isImportant, Status? status)
        {
            
            List<Taskk> result = new List<Taskk>();
            Console.WriteLine(startTime + " " + deadLine);
            
            Account currentAccount = await GetCurrentAccount();
           client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                $"api/tasks?startTime={startTime}&deadLine={deadLine}&isImportant={isImportant}&status={status}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Taskk>>(message);
            
            return result; 
        }
        
        public async Task<IList<Taskk>> GetAllRelativeTasks(DateTime? startTime, DateTime? deadLine, bool?isImportant, Status? status)
        {
            
            List<Taskk> result = new List<Taskk>();
            Console.WriteLine(startTime + " " + deadLine);
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/tasks?username={currentAccount.username}&startTime={startTime}&deadLine={deadLine}&isImportant={isImportant}&status={status}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Taskk>>(message);
            
            return result; 
        }

        public async Task RemoveTask(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Taskk> GetTaskById(int id)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/task?id={id}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            Taskk taskk= JsonConvert.DeserializeObject<Taskk>(message);
            
            return taskk; 
        }

     
    }
}