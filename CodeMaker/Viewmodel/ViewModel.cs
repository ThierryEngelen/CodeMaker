using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CodeMaker.Models;

namespace CodeMaker
{
    public class ViewModel:ViewModelBase
    {
		private Project _selectedProject;
		private Document _selectedDocument;
		private Subject _selectedSubject;

		private ProjectList _projectList = null;
		private ObservableCollection<Project> _currentProjects= null;
		private DocumentList _documentList=null;
		private ObservableCollection<Document>_currentDocuments=null;
		private SubjectList _subjectList = null;
		private ObservableCollection<Subject> _currentSubjects = null;


		#region ComboboxLijst_Project

		public ProjectList ProjectList
		{
			get
			{
				_projectList ??= new ProjectList();
				return _projectList;
			}
			set { _projectList = value; }
		}
		public ObservableCollection<Project> CurrentProjects
		{
			get
			{
				_currentProjects??= new ObservableCollection<Project>(ProjectList.Projects.Select(s => s).ToList());
				return _currentProjects;
			}
			set { ProjectList.Projects = value.Cast<Project>().ToList(); }
		}
		#endregion

		#region ComboboxLijst_Document

		public DocumentList DocumentList
		{
			get
			{
				_documentList ??= new DocumentList();
				return _documentList;
			}
			set { _documentList = value; }
		}
		public ObservableCollection<Document> CurrentDocuments
		{
			get
			{
				_currentDocuments ??= new ObservableCollection<Document>(DocumentList.Documents.Select(s => s).ToList());
				return _currentDocuments;
			}
			set { DocumentList.Documents = value.Cast<Document>().ToList(); }
		}
		#endregion

		#region ComboboxLijst_Subject

		public SubjectList SubjectList
		{
			get
			{
				_subjectList ??= new SubjectList();
				return _subjectList;
			}
			set { _subjectList = value; }
		}
		public ObservableCollection<Subject> CurrentSubjects
		{
			get
			{
				_currentSubjects??= new ObservableCollection<Subject>(SubjectList.Subjects.Select(s => s).ToList());
				return _currentSubjects;
			}
			set { SubjectList.Subjects = value.Cast<Subject>().ToList(); }
		}
		#endregion ComboboxLijst_Subject

		public Project SelectedProject
		{
			get { return _selectedProject; }
			set { _selectedProject = value; Notify(); }
		}
		public Document SelectedDocument
		{
			get { return _selectedDocument; }
			set { _selectedDocument = value; Notify(); }
		}
		
		public Subject SelectedSubject
		{
			get { return _selectedSubject; }
			set { _selectedSubject= value;Notify(); }
		}


	}
}
