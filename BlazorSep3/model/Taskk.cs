using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BlazorSep3.model
{
    public class Taskk
    {
        public int id { get; set; }
        [Required] [JsonProperty("title")] 
        public string Title { get; set; }

        [Required]
        [JsonProperty("description")]
        public string Description { get; set; }

        [Required]
        [JsonProperty("specialties")]
        public Dictionary<string, int> Specialities { get; set; } = new Dictionary<string, int>();

        [Required] [JsonProperty("startDate")] 
        public DateTime StartDate { get; set; }

        [Required]
        [JsonProperty("estimatedTime")]
        public double Estimate { get; set; }

        [Required] [JsonProperty("deadline")] 
        public DateTime Deadline { get; set; }

        [Required] [JsonProperty("status")] 
        public Status Status { get; set; } = Status.Created;
        [Required] [JsonProperty("spentHours")] 
        public double SpentHours { get; set; } = 0;


        public override string ToString()
        {
            string specialities = "";
            foreach (var key in Specialities)
            {
                specialities += $@"{key} {key.Value} /n";
            }

            return $@"title: {Title} Description: {Description} StartDade: {StartDate}
            Estimate: {Estimate} Deadline: {Deadline} Specialities: {specialities}";
        }

        public int GetFinalNumberOfPeople()
        {
            int final = 0;
            foreach (var key in Specialities)
            {
                final += key.Value;
            }

            return final;
        }
    }
}