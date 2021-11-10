using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BlazorSep3.model
{
    public class Profile
    {
        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [Required]
        [JsonProperty("specialities")]
        public string Specialities { get; set; }
        [Required]
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
        [Required]
        [JsonProperty("role")]
        public String Role { get; set; }
    }
}