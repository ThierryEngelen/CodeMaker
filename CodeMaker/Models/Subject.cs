using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeMaker.Models
{
    public class Subject
    {
        public Subject() { }
            
        [JsonPropertyName("subjecttype")]
        public string SubjectType { get; set; }

        [JsonPropertyName("subjecteng")]
        public string SubjectEng { get; set; }

        [JsonPropertyName("subjectabr")]
        public string SubjectAbr{ get; set; }
    }
}
