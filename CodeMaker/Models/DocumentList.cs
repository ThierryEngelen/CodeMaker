using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace CodeMaker.Models
{
    public class DocumentList
    {
        public DocumentList() 
        {
            LoadData();
        }
        public DocumentList(string document)
        {
            LoadData();
        }
        private static string _newFilePath => $@"C:\Users\Tine\source\repos\CodeMaker\CodeMaker";//Directory.GetCurrentDirectory(); 
        private static string _projectFilePath => $@"{_newFilePath}\Data\Projects.json";
        private static string _documentFilePath => $@"{_newFilePath}\Data\Documents.json";
        private static string _subjectFilePath => $@"{_newFilePath}\Data\Subjects.json";
        public List<Document> Documents { get; set; } = new List<Document>();

        public void LoadData()
        {
            if (File.Exists(_projectFilePath))
            {
                ImportDocuments((File.ReadAllText(_projectFilePath)));
            }
            if (File.Exists(_documentFilePath))
            {
                ImportDocuments((File.ReadAllText(_documentFilePath)));
            }
            if (File.Exists(_subjectFilePath))
            {
                ImportDocuments((File.ReadAllText(_subjectFilePath)));
            }
        }
        public void ImportDocuments(string json)
        {
            var data = JsonSerializer.Deserialize<List<Document>>(json);
                if (data!=null)
            {
                foreach (var doc in data)
                {
                    Documents.Add(doc);
                }
            }
        }
    }
}
