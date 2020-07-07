using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TeamBoardGUI.Tools;

namespace TeamBoardGUI.ViewModels
{
    public class HostOldViewModel : INotifyPropertyChanged
    {
        public ICommand BtnHostServer { get; set; }
        public MainWindowViewModel ViewModelParent { get; set; }
        public HostOldViewModel(MainWindowViewModel mainViewModel)
        {
            ViewModelParent = mainViewModel;
            BtnHostServer = new BaseCommand(HostServer);
        }
        public void HostServer(object obj)
        {

            //ViewModelParent.OpenHostNew(null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
