using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace CodeMaker
{
    public class ViewModelBase : INotifyPropertyChanged //geeft aan dat de Property is gewijzigd
    {
            public event PropertyChangedEventHandler PropertyChanged;

        public void Notify([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(caller));
        }

    }
}
