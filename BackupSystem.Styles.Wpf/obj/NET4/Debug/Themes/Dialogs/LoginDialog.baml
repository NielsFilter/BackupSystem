   M S B A M L   `   `   `  ����S  OBackupSystem.Styles.Wpf, Version=0.14.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BackupSystem.Styles.Wpf.Controls BackupSystem.Styles.Wpf.Controls  5      c6clr-namespace:BackupSystem.Styles.Wpf.Controls.Dialogs(BackupSystem.Styles.Wpf.Controls.Dialogs  5      :    4BackupSystem.Styles.Wpf.Controls.Dialogs.LoginDialog   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      CControls.clr-namespace:BackupSystem.Styles.Wpf.Controls     5      JDialogs6clr-namespace:BackupSystem.Styles.Wpf.Controls.Dialogs     5      >   8BackupSystem.Styles.Wpf.Controls.Dialogs.BaseMetroDialog    Loaded$  Dialog_Loaded��5      .��5      � $��0 10 0 0q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   $��20��5
      �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0 5 0 0q�5         DialogMessageFontSize#��[  5      $
��Wrap=�5      ��5      �� *	Message+ �� RelativeSource ��  �� AncestorType$ Dialogs:LoginDialogL� �� Mode$ FindAncestor=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� *
Foreground+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=��� 5   
   -   5         ��Name$ PART_TextBox��5      $��1��5      $��0 5 0 0q�5      #��[  5       �� TextWrapping$
 Wrap=�5      4   .BackupSystem.Styles.Wpf.Controls.TextboxHelper   	Watermark 5      �� *UsernameWatermark+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=���5      �� *
Username+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=���5      �� *
Foreground+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=�G� 5   
   -   5        	 G�Name$	 PART_TextBox2��5       $��2��5      $��0 5 0 0q�5      #��[  5       5!      �� *PasswordWatermark+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=���5"      �� *
Foreground+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=��� 5#   
   $��3��6   
 �� Orientation$
 
Horizontal=�5$      $��Right=�5%      $��85��5&      .+�5'      �� -   5         ��Name$ PART_AffirmativeButton��5'      $��35��5(      $��80��5)        AccentedDialogSquareButton#���  5*      $��0 0 5 0q�5,      ��5+      �� *AffirmativeButtonText+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=�5,      �� 5-      -   5        $ PART_NegativeButton��5-      $��35��5.      $��80��5/      $��5 0 5 0q�52      y�50      �� * NegativeButtonButtonVisibility+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=���51      �� *NegativeButtonText+ �� $ Dialogs:LoginDialogL�$ FindAncestor=�$ PropertyChanged=�52      53      54      55      