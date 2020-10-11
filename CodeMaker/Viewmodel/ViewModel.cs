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
		private Document _selectedProject;
		private Document _selectedDocument;
		private Document _selectedSubject;

		private DocumentList _projectList = null;
		private ObservableCollection<Document> _currentProjects= null;
		private DocumentList _documentList=null;
		private ObservableCollection<Document>_currentDocuments=null;
		private DocumentList _subjectList = null;
		private ObservableCollection<Document> _currentSubjects = null;


		#region ComboboxLijst_Project

		public DocumentList ProjectList
		{
			get
			{
				_projectList ??= new DocumentList();
				return _projectList;
			}
			set { _projectList = value; }
		}
		public ObservableCollection<Document> CurrentProjects
		{
			get
			{
				_currentProjects??= new ObservableCollection<Document>(DocumentList.Documents.Select(s => s).ToList());
				return _currentProjects;
			}
			set { DocumentList.Documents = value.Cast<Document>().ToList(); }
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

		public DocumentList SubjectList
		{
			get
			{
				_subjectList ??= new DocumentList();
				return _subjectList;
			}
			set { _subjectList = value; }
		}
		public ObservableCollection<Document> CurrentSubjects
		{
			get
			{
				_currentSubjects ??= new ObservableCollection<Document>(DocumentList.Documents.Select(s => s).ToList());
				return _currentSubjects;
			}
			set { DocumentList.Documents = value.Cast<Document>().ToList(); }
		}
		#endregion ComboboxLijst_Subject

		public Document SelectedProject
		{
			get { return _selectedProject; }
			set { _selectedProject = value; Notify(); }
		}
		public Document SelectedDocument
		{
			get { return _selectedDocument; }
			set { _selectedDocument = value; Notify(); }
		}
		
		public Document SelectedSubject
		{
			get { return _selectedSubject; }
			set { _selectedSubject= value;Notify(); }
		}


	}
}
