using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel _viewModel = null;
          
        public ViewModel MainViewModel
        {
            get { _viewModel ??= new ViewModel(); return _viewModel; }
            set { _viewModel = value; }
        }

       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
        }

        private void Cbx_Project_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cbx_Project.SelectedItem.ToString();
        }
        private void Cbx_Document_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Cbx_Document.SelectedItem.ToString();
        }
        private void Cbx_Subject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Cbx_Subject.SelectedItem.ToString();
        }
    }
}
