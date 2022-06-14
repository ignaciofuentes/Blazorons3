using System;
using System.Text.Json.Serialization;

namespace Blazorons3.Models
{
    public class GitHubBranch
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}

