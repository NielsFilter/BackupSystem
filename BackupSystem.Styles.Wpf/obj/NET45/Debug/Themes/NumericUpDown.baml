   M S B A M L   `   `   `  ����I  EMahApps.Metro, Version=0.14.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MahApps.Metro.ControlsMahApps.Metro.Controls  5      C&clr-namespace:MahApps.Metro.ConvertersMahApps.Metro.Converters  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source9    3MahApps.Metro.Converters.ThicknessToDoubleConverter   ThicknessToDoubleConverter*   $MahApps.Metro.Controls.NumericUpDown �� 
TargetType �� Property �� Value  	TextBrush  TextBoxBorderBrush+   %MahApps.Metro.Controls.ControlsHelper  TextBoxFocusBorderBrush  TextBoxMouseOverBorderBrush  ContentFontFamily  ContentFontSize*   $MahApps.Metro.Controls.TextboxHelper  ControlBackgroundBrush  ValidationErrorTemplate �� 
TargetType ��Name �� 	Converter � ColumnDefinitions	 ��Name
 ��Name J� SnapsToDevicePixels$ �� HorizontalScrollBarVisibility" �� VerticalScrollBarVisibility   
IsReadOnly �� 
IsReadOnly   ClearTextButton   	Watermark ��Name   Delay �� Delay 	 ChromelessButtonStyle F�Name �� Stretch 
 
GrayBrush1 �� Triggers P� Property P� Value P� 
SourceName �� 
TargetName  
GrayBrush8  AccentColorBrush  
BlackBrush  
WhiteBrush �� RelativeSource �� Path�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1Controls$clr-namespace:MahApps.Metro.Controls  5      5
converters&clr-namespace:MahApps.Metro.Converters  5        5      �� 5   
   $J Dpack://application:,,,/MahApps.Metro;component/Styles/VS/Colors.xaml?�6   %v  &	        '       7   7      5
      6,   �� 5      "  6   .�5   
   ��  � ��$ 1q�5      �� 5   
    �@J�SnapsToDevicePixels . 5      �� 5   
    � ��# �  5      �� 5   
    � ��# �  5      �� 5   
    �@ FocusBorderBrush# �  5      �� 5   
    �@ MouseOverBorderBrush# �  5      �� 5   
    � ��$ Center=�5      �� 5   
    � ��# �  5      �� 5   
    � ��# �  5      �� 5   
    �@ IsMonitoring . 5       �� 5!   
    � ��$
 Auto=�5"      �� 5#   
    � ��$
 Auto=�5$      �� 5%   
    � ��$ 26��5&      �� 5'   
    � ��$ 62��5(      �� 5)   
    � ��# �  5*      �� 5+   
    �@=�ErrorTemplate# �  5,      �� 5-   
    � |� .  5.      �� 5/   
    � �� 50      �� 51      "  6"   .R�52      � #��z��6   #��z��53      #��z��54      #��z��55      #��z��56      #��z��57      .+�58      �� $
 Base��6$   #��z��59   $   #��z��5;   $   ��5:   $   �� *BorderThickness+8   5;   $   �� 5<      $ FocusRectangle��6$   $y�	Collapsed=�5=   $   ��5>   $   �� *BorderThickness+8  � 5?       5@      �� 5A   "   �� 5B   "   $	 PART_NumericUpColumn��63   $��20 �5C   3   �� 5D   "   $	 PART_NumericDownColumn��63   $��20 �5E   3   .+�5H      �� $
 PART_TextBox��6&   $��20��5I   &   #��z��5J   &   #��z��5K   &   $��Stretch=�5L   &   $��Right=�5M   &   #��z��5N   &   # z 5O   &   $��0q�5P   &   |�. # z��5S   &   # z��5T   &   # z 5U   &   #��z��5V   &   #��z��5W   &   # z 5X   &   # z 5Y   &   ��5Q   &   Z� 5Y   &   �� 5Z      $ PART_NumericUp��6+   $��1��5[   +   $��2,2,0,2q�5\   +   # z 5]   +   #��z��5^   +   #��� 	 5_   +   ��.  .��5a   "   F� $ 	PolygonUp��6'   $��14��5b   '   $��14��5c   '   $
 Fill=�5d   '   #��� 
 5e   '   |�������!�@�q��!�@�q��@�e��@�e@�q�@�q@�q�@�q@�e��@�e��@�q���!@�q���!��������!5f   '   5g      �� 5h      $ PART_NumericDown��6+   $��2��5i   +   $��0,2,2,2q�5j   +   $��Center=�5k   +   # z 5l   +   #��� 	 5m   +   #��z��5n   +   ��.  .��5p   "   F� $ PolygonDown��6'   $��14��5q   '   $��3��5r   '   $
 Fill=�5s   '   #��� 
 5t   '   4������!��C�@�e��C�@�e c����! c����!��C5u   '   5v      5w      5x       5y      P� 5z       �@ 
IsReadOnly . . �5|      ��  �@ InterceptArrowKeys .  5}   %   �� 5~       �@ InterceptMouseWheel .  5   %   �� 5�       �@ InterceptManualEnter .  5�   %   5�      P� 5�      $ PART_NumericUp��5�   "    �@J�IsMouseOver . . �5�      �� $ PART_NumericUp��6%   # �  5�   %    � ���� 5�      $ 	PolygonUp��6%   # �  5�   %    � ��5�      P� 5�      $ PART_NumericUp��5�   "    � �� . . �5�      �� $ PART_NumericUp��6%   # �  5�   %    � ���� 5�      $ 	PolygonUp��6%   # �  5�   %    � ��5�      P� 5�      $ PART_NumericDown��5�   "    �@J�IsMouseOver . . �5�      �� $ PART_NumericDown��6%   # �  5�   %    � ���� 5�      $ PolygonDown��6%   # �  5�   %    � ��5�      P� 5�      $ PART_NumericDown��5�   "    � �� . . �5�      �� $ PART_NumericDown��6%   # �  5�   %    � ���� 5�      $ PolygonDown��6%   # �  5�   %    � ��5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ FocusRectangle��6%    � y�$ Visible=�5�   %   �� 5�      $ FocusRectangle��6%    5�   %   ��  �� *TemplatedParent+$4 .(Controls:ControlsHelper.MouseOverBorderBrush)� � ��5�      P� 5�      $ PART_TextBox��5�   "    �@J�	IsFocused . . �5�      �� $ FocusRectangle��6%    � y�$ Visible=�5�   %   �� 5�      $ FocusRectangle��6%    5�   %   ��  �� *TemplatedParent+$0 *(Controls:ControlsHelper.FocusBorderBrush)� � ��5�      P� 5�       �@J�	IsFocused . . �5�      �� $ FocusRectangle��6%    � y�$ Visible=�5�   %   �� 5�      $ FocusRectangle��6%    5�   %   ��  �� *TemplatedParent+$0 *(Controls:ControlsHelper.FocusBorderBrush)� � ��5�      P� 5�       �@ HideUpDownButtons . . �5�      �� $ PART_NumericUp��6%    � y�$ 	Collapsed=�5�   %   �� 5�      $ PART_NumericDown��6%    � y�$ 	Collapsed=�5�   %   �� 5�      $ PART_NumericUpColumn��6%    � ��$ 0 �5�   %   �� 5�      $ PART_NumericDownColumn��6%    � ��$ 0 �5�   %   5�      5�      5�      5�      5�      