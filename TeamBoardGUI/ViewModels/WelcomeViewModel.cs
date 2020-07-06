using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using TeamBoardGUI.Tools;

namespace TeamBoardGUI.ViewModels
{
    public class WelcomeViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel ViewModelParent { get; set; }
        public ICommand ShowHost { get; set; }

        private object _page;

        public object Page {
            get { return _page; }

            set { _page = value; OnPropertyChanged("Page"); }
        }

        public WelcomeViewModel(MainWindowViewModel mainViewModel)
        {
            ViewModelParent = mainViewModel;
            ShowHost = new BaseCommand(OpenHost);
        }

        public void OpenHost(object obj)
        {
            ViewModelParent.OpenHost(null);
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
