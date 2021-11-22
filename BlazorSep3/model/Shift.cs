using System;
using Newtonsoft.Json;

namespace BlazorSep3.model
{
    public class Shift
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
    }
}