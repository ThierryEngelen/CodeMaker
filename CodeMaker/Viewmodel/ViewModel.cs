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
		private DocumentList _documentList=null;
		private ObservableCollection<Document>_currentDocuments=null;
		private DocumentList _subjectList = null;
		private ObservableCollection<Document> _currentSubjects = null;

//		private List<string> _onderwerp = new List<string>() { "architectuur", "technieken", "stabiliteit" };
		
		private string _selectedDocument;
		private string _selectedOnderwerp;

		public DocumentList DocumentList
		{
			get { _documentList ??= new DocumentList();
					return _documentList; }
			set { _documentList=value; }
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
        #region ComboboxLijst
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
        #endregion ComboboxLijst

        public string SelectedDocument
		{
			get { return _selectedDocument; }
			set { _selectedDocument = value;Notify(); }
		}

		public string SelectedOnderwerp
		{
			get { return _selectedOnderwerp; }
			set { _selectedOnderwerp = value; Notify(); }
		}


	}
}
