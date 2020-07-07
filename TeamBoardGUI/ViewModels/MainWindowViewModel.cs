using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TeamBoardGUI.Tools;

namespace TeamBoardGUI.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        //PROPERTIES
        private object _page; //Visible Page
        public object Page {
            get { return _page; }

            set { _page = value; OnPropertyChanged("Page"); }
        }

        //CONSTRUCTOR
        public MainWindowViewModel()
        {
            Page = new WelcomeViewModel(this);
        }

        //METHODS
        //pages
        public void OpenWelcome(object obj) { Page = new WelcomeViewModel(this); }
        public void OpenHost(object obj) { Page = new HostViewModel(this); }
        public void OpenHostNew(object obj) { Page = new HostNewViewModel(this); }
        public void OpenHostExisting(object obj) { Page = new HostOldViewModel(this); }

        //EXTRAS
        //Updates view upon change
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
