   M S B A M L   `   `   `  ����G  CTeamBoardGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TeamBoardGUITeamBoardGUI  5   	   A%clr-namespace:TeamBoardGUI.ViewModelsTeamBoardGUI.ViewModels  5   	   7 clr-namespace:TeamBoardGUI.ViewsTeamBoardGUI.Views  5   	       TeamBoardGUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TeamBoardGUI     5   	   <
viewmodels%clr-namespace:TeamBoardGUI.ViewModels     5   	   2views clr-namespace:TeamBoardGUI.Views     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5       �� DataType.   (TeamBoardGUI.ViewModels.WelcomeViewModel$   TeamBoardGUI.Views.WelcomeView+   %TeamBoardGUI.ViewModels.HostViewModel!   TeamBoardGUI.Views.HostView.   (TeamBoardGUI.ViewModels.HostNewViewModel$   TeamBoardGUI.Views.HostNewView.   (TeamBoardGUI.ViewModels.HostOldViewModel$   TeamBoardGUI.Views.HostOldView��%,  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      � 
����ح� � ColumnDefinitions 5   
    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5       $��* �6   .+�5"   
   �� $��0��6   $��0��6)   �� 5#   
   -   5         ��Name$ Pages��5#      $��1��6A   $��2��6Q   ��6(   �� *Page+6Q   5$      5%      