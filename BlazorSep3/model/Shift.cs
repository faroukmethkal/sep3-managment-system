using System;
using Newtonsoft.Json;

namespace BlazorSep3.model
{
    public class Shift
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")] 
        public string Name { get; set; }
        [JsonProperty("date")] 
        public  DateTime Date { get; set; }
        [JsonProperty("startTime")] 
        public DateTime StartTime { get; set; }
        [JsonProperty("endTime")] 
        public DateTime EndTime { get; set; }
        [JsonProperty("description")] 
        public string Description { get; set; }
        [JsonProperty("numberOfEmployees")] 
        public int NumberOfEmployee { get; set; }

        public override string ToString()
        {
            return $"@{Id}: name {Name} date: {Date} start time: {StartTime} end time: {EndTime} description: {Description} n.of employ: {NumberOfEmployee} ";
        }
    }
}