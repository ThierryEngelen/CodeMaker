using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace CodeMaker.Models
{
    public class SubjectList
    {
        public SubjectList()
        {
            LoadData();
        }
        private static string _newFilePath => $@"C:\Users\Tine\source\repos\CodeMaker\CodeMaker";//Directory.GetCurrentDirectory(); 
        private static string _subjectFilePath => $@"{_newFilePath}\Data\Subjects.json";
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public void LoadData()
        {
            if (File.Exists(_subjectFilePath))
            {
                ImportDocuments((File.ReadAllText(_subjectFilePath)));
            }

        }
        public void ImportDocuments(string json)
        {
            var data = JsonSerializer.Deserialize<List<Subject>>(json);
            if (data != null)
            {
                foreach (var doc in data)
                {
                    Subjects.Add(doc);
                }
            }
        }
    }
}
