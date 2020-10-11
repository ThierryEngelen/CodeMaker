using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeMaker.Models
{
    public class Document
    {
        public Document() { }

        [JsonPropertyName("project")]
        public string ProjectType { get; set; }

        [JsonPropertyName("doctype")]
        public string DocType{ get; set; }

        [JsonPropertyName("subjecttype")]
        public string SubjectType { get; set; }

        [JsonPropertyName("docabr")]
        public string DocAbr { get; set; }

        [JsonPropertyName("subjectabr")]
        public string SubjectAbr{ get; set; }
    }
}
