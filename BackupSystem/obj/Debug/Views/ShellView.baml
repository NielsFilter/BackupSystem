   M S B A M L   `   `   `  ����X  TBackupSystem.ApplicationLogic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�]clr-namespace:BackupSystem.ApplicationLogic.ViewModels;assembly=BackupSystem.ApplicationLogic(BackupSystem.ApplicationLogic.ViewModels  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   S OBackupSystem.Styles.Wpf, Version=0.14.0.0, Culture=neutral, PublicKeyToken=nulltOclr-namespace:BackupSystem.Styles.Wpf.Controls;assembly=BackupSystem.Styles.Wpf BackupSystem.Styles.Wpf.Controls 5   	   N JBackupSystem.UI.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BackupSystem.UI.WpfBackupSystem.UI.Wpf 5   	   )   #BackupSystem.UI.Wpf.Views.ShellView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   lvm]clr-namespace:BackupSystem.ApplicationLogic.ViewModels;assembly=BackupSystem.ApplicationLogic     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   ]mOclr-namespace:BackupSystem.Styles.Wpf.Controls;assembly=BackupSystem.Styles.Wpf     5   	   3local!clr-namespace:BackupSystem.UI.Wpf     5   	   -   5          � WindowState$  	Maximized=�5   	    � Title$ Backup System��5	   	   $	��768��6   $
��1024��6,    � DataContext 5      =   7BackupSystem.ApplicationLogic.ViewModels.ShellViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��324* �6   �� 5      $
��149* �6   �� 5      $
��174* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   y�6   �� *
IsSaveShow+ �� Mode$ TwoWay=�   boolToVisibilityConverter �� 	Converter# [  ._�5      �� .+�5      �� ��6   �� *SaveMessageHeader+$ OneWay=��� 5      ��6   �� *SaveMessage+$ OneWay=�5      5       �� 5"   
   $��1��6   y�6   �� *IsErrorShow+$ TwoWay=�# [  ._�5#      �� .+�5$      �� ��6   �� *ErrorMessageHeader+$ OneWay=��� 5%      ��6   �� *ErrorMessage+$ OneWay=�5&      5'      � 5)   
   -   5         �Name$ grdTop��5)      $��
20,30,20,0q�6    J� RenderTransformOrigin$ 0.5,0.5&�63    5*      �� 5+      $��* �6#   �� 5,      $
��Auto �6#   .+�5/      � ��6   �� *PanelMessageType+  stringToStyleConverter# [ y�6n   �� *IsPanelMessageShow+# [   50      �� 51      $
��Auto �6$   .+�53      ��   	TbHeading#��[ 6   ��6?   �� *PanelMessageHeader+54      �� 57      	 �� Orientation$	 
Horizontal=�6   $��Right=�62   $��1��6N   y�58      �� *Context.LoggedInUser+$ OneWay=� ! hasValueToVisibilityConverter# [ .+�59      �� -   5          BtnHome#���  59      
 � ToolTip$
 Go to Home Page��6;   6U   �� 5:      -   5          BtnMenu#��[ 5:      $
 	Open Menu��6:   y�6N   �� *IsMenuVisible+$ TwoWay=�# [   �� ConverterParameter$
 True��6�   5;      5<      B  <BackupSystem.Styles.Wpf.Controls.TransitioningContentControl  5@   
   -   5          Name$ contentMain��5@   (   $��1��6=   $��3��6J      
Transition$ RightReplace=�6[   � 5C   
   
������ $��4��6(   y�69   �� *	IsLoading+# [  $ TwoWay=�.+�5D      �  J� Opacity$	 0.9Q�6   $��Stretch=�6!   $��Stretch=�6=     
WhiteBrush#���  6[   �� 5E      $	 Vertical=�6   $��Center=�64   $��Center=�6O   .+�5F      3  -BackupSystem.Styles.Wpf.Controls.ProgressRing    AccentColorBrush#���  6%   $	��100��6U   $	��100��6b      IsActive 6n   �� *	IsLoading+�� 5G        TbSubHeading#��[ 6A   ��6!   �� *LoadingMessage+6A   5H      5I      � 5L   
   $��4��6   $��1��6    y�61   �� *Context.LoggedInUser+$ OneWay=�# [ .+�5M      � y�6   �� *IsMenuVisible+$ TwoWay=�# [  .+�5N      -  'BackupSystem.Styles.Wpf.Controls.Flyout  
������    AnimateOnPositionChange .    Header$
 Menu��5O         Position$ Right=�6!      Theme$ Accent=�62      IsOpen 5P      �� *IsMenuVisible+$ TwoWay=�.��5R      �� $	 Vertical=�6!   $	��200��68   $
��15,5q�6D   y�5S      �� *IsMenuVisible+$ TwoWay=�# [  .+�5V      �� $��User Module��6$   
�������67   �� 5W      $��System users��6!   �� 5X      -   5        $��Generate Activation key��5X   !   6C   �� 5Y      -   5        $��Create Backup��5Y   !   69   �� 5Z      -   5        $��Backup Items��5Z   !   68   5[      5]      5^      5_      5`      5a      