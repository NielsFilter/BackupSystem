   M S B A M L   `   `   `  ����S  OBackupSystem.Styles.Wpf, Version=0.14.0.0, Culture=neutral, PublicKeyToken=nulltOclr-namespace:BackupSystem.Styles.Wpf.Controls;assembly=BackupSystem.Styles.Wpf BackupSystem.Styles.Wpf.Controls  5      T PBackupSystem.Controls.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhJclr-namespace:BackupSystem.Controls.Wpf;assembly=BackupSystem.Controls.WpfBackupSystem.Controls.Wpf 5       BackupSystem.UI.Wpf1   +BackupSystem.UI.Wpf.Views.Core.UserListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ]mOclr-namespace:BackupSystem.Styles.Wpf.Controls;assembly=BackupSystem.Styles.Wpf     5      \ctrlsJclr-namespace:BackupSystem.Controls.Wpf;assembly=BackupSystem.Controls.Wpf     5      -   5        .��5
      � -   5          �Name$
  Root��5
   /      
GrdContent#��[  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $
��0,10q�6;   .+�5      ��  
 BtnAdd#��[ 6    � ToolTip$ Add New��65   ��6G   �� *AddNewCommand+5      �� 5   
   -   5        $��0��5      $	��300��6   $��16(�6+   $��Right=�69   $��Bottom=�6U   4   .BackupSystem.Styles.Wpf.Controls.TextboxHelper   	Watermark$ Type to search...��5      ��5      �� *Pager.SearchText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      � 5   
   $��1��6    5      �� 5      �� 5      $
��Auto �6    �� 5        InfoBarHeight#��[ 6    .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ dgList��5"   $   $��0��6      AutoGenerateColumns .    MetroDataGrid#��[ 6P   	 �� SelectedItem	 5#      �� *SelectedItem+$ TwoWay=���5$      �� *	ListPaged+
   Columns
 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
Username+6F     5(      $
 Role��6B    6)   �� *Role+6B     5)      $ Status��6�    6)   �� *
IsActive+  boolToCustomTextConverter �� 	Converter# [  �� ConverterParameter$ Active|Inactive��6�   5+      &   BackupSystem.Controls.Wpf.Paging  5.      $��Center=�63   $��0��6P   $��Bottom=�6]      Pager 6   �� *Pager+6]   �� 51      $��1��6   $��Stretch=�6(   $��1��6F   �� 52      $��2��6     BrdSelectionPanel#��[ 6"   ._�53      � .+�54      ��   TbInfo1#��[ 6      NoSelection#��[ 55       y�56       �� *SelectedItem+ �� ElementName$ dgList�� ! hasValueToVisibilityConverter# [ $
 True��� 58       � DataContext 6   �� *SelectedItem+$ dgList��y�59      �� *SelectedItem+$ dgList��# [  � ColumnDefinitions 5:      �� 5;      �� 5<      .+�5?      �� $ Vertical=�6%   .+�5@      �� #��[ 6B   ��6(   �� *
Username+6B   �� 5A       	 TbInfo6#��[	 6>   ��6(   �� *Role+6>   5B      �� 5D      $��1��6$   #��[	 64   $��Right=�6U   ��5E   $   �� *
IsActive+# [ $ Active|Inactive���� 5G      $��1��6%   $ 
Horizontal=�65   $��Right=�6N   $��Bottom=�6j    6�   �� *DataContext+$
 Root��.+�5H      ��  
 	BtnDelete#��[
 6%   $ Delete��6H   ��6Y   �� *DeleteCommand+�� 5I        BtnEdit#��[ 6%   $
 Edit��6F   ��6U   �� *EditCommand+5J      5K      5L      5M      5N      5P      5Q      