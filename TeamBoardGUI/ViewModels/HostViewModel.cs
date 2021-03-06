﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using TeamBoardGUI.Tools;

namespace TeamBoardGUI.ViewModels
{
    public class HostViewModel : INotifyPropertyChanged
    {
        public ICommand BtnOpenHostNew { get; set; }
        public ICommand BtnOpenHostExisting { get; set; }
        public MainWindowViewModel ViewModelParent { get; set; }
        public HostViewModel(MainWindowViewModel mainViewModel)
        {
            ViewModelParent = mainViewModel;
            BtnOpenHostNew = new BaseCommand(OpenHostNew);
            BtnOpenHostExisting = new BaseCommand(OpenHostExisting);
        }

        public void OpenHostNew(object obj)
        {
            ViewModelParent.OpenHostNew(null);
        }
        public void OpenHostExisting(object obj)
        {
            ViewModelParent.OpenHostExisting(null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
