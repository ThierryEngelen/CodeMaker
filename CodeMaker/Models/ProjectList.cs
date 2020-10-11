using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace CodeMaker.Models
{
    public class ProjectList
    {
        public ProjectList()
        {
            LoadData();
        }
        private static string _newFilePath => $@"C:\Users\Tine\source\repos\CodeMaker\CodeMaker";//Directory.GetCurrentDirectory(); 
        private static string _projectFilePath => $@"{_newFilePath}\Data\Projects.json";
        public List<Project> Projects { get; set; } = new List<Project>();

        public void LoadData()
        {
            if (File.Exists(_projectFilePath))
            {
                ImportDocuments((File.ReadAllText(_projectFilePath)));
            }

        }
        public void ImportDocuments(string json)
        {
            var data = JsonSerializer.Deserialize<List<Project>>(json);
            if (data != null)
            {
                foreach (var doc in data)
                {
                    Projects.Add(doc);
                }
            }
        }
    }
}
