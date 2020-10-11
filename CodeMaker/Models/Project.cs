using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeMaker.Models
{
    public class Project
    {
        public Project() { }

        [JsonPropertyName("project")]
        public string ProjectType { get; set; }

    }
}
