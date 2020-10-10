using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeMaker.Models
{
    public class Document
    {
        public Document() { }

        [JsonPropertyName("doctype")]
        public string DocType{ get; set; }

        [JsonPropertyName("subjecttype")]
        public string SubjectType { get; set; }

    }
}
