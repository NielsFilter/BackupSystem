   M S B A M L   `   `   `  ����S  OBackupSystem.Styles.Wpf, Version=0.14.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:BackupSystem.Styles.Wpf.Controls.Dialogs(BackupSystem.Styles.Wpf.Controls.Dialogs  5      S.clr-namespace:BackupSystem.Styles.Wpf.Controls BackupSystem.Styles.Wpf.Controls  5      :    4BackupSystem.Styles.Wpf.Controls.Dialogs.InputDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      JDialogs6clr-namespace:BackupSystem.Styles.Wpf.Controls.Dialogs     5      Ccontrols.clr-namespace:BackupSystem.Styles.Wpf.Controls     5      >   8BackupSystem.Styles.Wpf.Controls.Dialogs.BaseMetroDialog    Loaded$  Dialog_Loaded��5      .��5      � $��0 10 0 0q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   $��20��5
      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0 5 0 0q�5         DialogMessageFontSize#��[  5      $
��Wrap=�5      ��5      �� *	Message+ �� RelativeSource ��  �� AncestorType$ Dialogs:InputDialogL� �� Mode$ FindAncestor=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� *
Foreground+ �� $ Dialogs:InputDialogL�$ FindAncestor=�$ PropertyChanged=��� 5   
   -   5         ��Name$ PART_TextBox��5      $��1��5      $��0 5 0 0q�5      #��[  5        AccentColorBrush5   /BackupSystem.Styles.Wpf.Controls.ControlsHelper   FocusBorderBrush# �  5       �� TextWrapping$
 Wrap=�5      ��5      �� *Input+ �� $ Dialogs:InputDialogL�$ FindAncestor=�$ PropertyChanged=���5      �� *
Foreground+ �� $ Dialogs:InputDialogL�$ FindAncestor=�$ PropertyChanged=��� 5   
   $��2��6   	 �� Orientation$	 
Horizontal=�5      $��Right=�5      $��85��5       .+�5!      �� -   5        
 ��Name$
 PART_AffirmativeButton��5!      $��35��5"      $��80��5#        AccentedDialogSquareButton#���  5$      $��0 0 5 0q�5&      ��5%      �� *AffirmativeButtonText+ �� $ Dialogs:InputDialogL�$ FindAncestor=�$ PropertyChanged=�5&      �� 5'      -   5        $
 PART_NegativeButton��5'      $��35��5(      $��80��5)      $��5 0 5 0q�5+      ��5*      �� *NegativeButtonText+ �� $ Dialogs:InputDialogL�$ FindAncestor=�$ PropertyChanged=�5+      5,      5-      5.      