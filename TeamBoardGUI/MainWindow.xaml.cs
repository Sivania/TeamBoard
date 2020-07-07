using System;
using System.Collections.Generic;
using System.Windows;
using TeamBoardGUI.ViewModels;

namespace TeamBoardGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
