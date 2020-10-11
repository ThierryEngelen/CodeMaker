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
        public string DocType { get; set; }
        [JsonPropertyName("doceng")]
        public string DocEng { get; set; }
        [JsonPropertyName("docabr")]
        public string DocAbr { get; set; }
    }
}
