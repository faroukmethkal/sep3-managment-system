﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Relative Task--->>>>>>>>>>"+message);
            result = JsonConvert.DeserializeObject<List<Taskk>>(message);
            
            return result; 
        }

        public async Task RemoveTask(int id)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);

            var response = await client.DeleteAsync(client.BaseAddress + $"api/task?id={id}"); 
            
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
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

        public async Task EditTask(Taskk task)
        {
            string serializeTask = JsonConvert.SerializeObject(task);
            Console.WriteLine(serializeTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeTask, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + "api/task", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }
        
        public async Task TakeTask(int id)
        {
           // string serializeId = JsonConvert.SerializeObject(id);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
           // HttpContent content = new StringContent(serializeId, Encoding.UTF8, "application/json");
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/task?username={currentAccount.username}&taskId={id}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }
        }

        public async Task<IList<Taskk>> GetAllMyTasks(Status? status)
        {
            List<Taskk> result = new List<Taskk>();
            
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/myTasks?username={currentAccount.username}&status={status}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
            result = JsonConvert.DeserializeObject<List<Taskk>>(message);
            
            return result; 
        }

        public async Task ChangeStatus(int id, Status newStatus)
        {
            string serializeTask = JsonConvert.SerializeObject(newStatus);
            Console.WriteLine(serializeTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeTask, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + $"api/task/status?status={newStatus}&taskId={id}", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task<IList<Profile>> GetTeamWorkingOnTask(int taskId)
        {
            IList<Profile> team = new List<Profile>();

            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpResponseMessage response = 
                await client.GetAsync(client.BaseAddress + 
                                      $"api/employee/team?Id={taskId}"); 
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error, not response");
            }

            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
             team =  JsonConvert.DeserializeObject<List<Profile>>(message);
            
            return team; 
        }

        public async Task UnassignEmployeeFromTask(int taskId, string username)
        {
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);

            var response = await client.DeleteAsync(client.BaseAddress + $"api/employee/task?taskId={taskId}&username={username}"); 
            
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task AddHoursSpent(int taskId, double hours)
        {
            string serializeTask = JsonConvert.SerializeObject(hours);
            Console.WriteLine(serializeTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeTask, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + $"api/employee/task?spentHours={hours}&taskId={taskId}", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task ApproveTask(int id)
        {
            string serializeTask = JsonConvert.SerializeObject(Status.Approved);
            Console.WriteLine(serializeTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeTask, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + $"api/task/status?status={Status.Approved}&taskId={id}", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }

        public async Task DeclineTask(int id)
        {
            string serializeTask = JsonConvert.SerializeObject(Status.Rejected);
            Console.WriteLine(serializeTask);
            Account currentAccount = await GetCurrentAccount();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer" + currentAccount.Token);
            HttpContent content = new StringContent(serializeTask, Encoding.UTF8, "application/json"); 

            var response = await client.PutAsync(client.BaseAddress + $"api/task/status?status={Status.Rejected}&taskId={id}", content); 
            
            if (!response.IsSuccessStatusCode) throw new Exception("Server is down");
        }
    }
}