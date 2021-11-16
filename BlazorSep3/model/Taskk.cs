using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

public class Taskk
{
     [JsonProperty("id")]
    public int Id { get; set; }
    [Required] [JsonProperty("title")] public string Title { get; set; }

    [Required]
    [JsonProperty("description")]
    public string Description { get; set; }

    [Required]
    [JsonProperty("specialties")]
    public Dictionary<string, int> Specialities { get; set; } = new Dictionary<string, int>();

    
    [Required]
    [JsonProperty("startDate")]
    public DateTime StartDate { get; set; }

    [Required]
    [JsonProperty("estimatedTime")]
    public double Estimate { get; set; }

    [Required] [JsonProperty("deadline")] public DateTime Deadline { get; set; }


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
}