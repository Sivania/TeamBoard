using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeamBoardGUI.Views
{
    /// <summary>
    /// Interaction logic for WelcomeView.xaml
    /// </summary>
    public partial class WelcomeView : UserControl
    {
        public WelcomeView()
        {
            InitializeComponent();
        }

        private void BtnHost(object sender, RoutedEventArgs e)
        {
        }
        private void BtnJoin(object sender, RoutedEventArgs e)
        {

        }

        private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < e.NewSize.Height)
                WelcomePanel.Orientation = Orientation.Vertical;
            else
                WelcomePanel.Orientation = Orientation.Horizontal;
        }
    }
}
