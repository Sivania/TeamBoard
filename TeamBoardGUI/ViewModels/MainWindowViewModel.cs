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
        public ICommand ShowWelcome { get; set; }
        public ICommand ShowHost { get; set; }
        private object _page;

        public object Page {
            get { return _page; }

            set { _page = value; OnPropertyChanged("Page"); }
        }

        public MainWindowViewModel()
        {
            ShowWelcome = new BaseCommand(OpenWelcome);
            ShowHost = new BaseCommand(OpenHost);
            Page = new WelcomeViewModel(this);
        }

        public void OpenWelcome(object obj)
        {
            Page = new WelcomeViewModel(this);
        }
        public void OpenHost(object obj)
        {
            Page = new HostViewModel(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
