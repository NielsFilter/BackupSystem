   M S B A M L   `   `   `  ����S  OBackupSystem.Styles.Wpf, Version=0.14.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BackupSystem.Styles.Wpf.Controls BackupSystem.Styles.Wpf.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089    BooleanToVisibilityConverter  �� 
TargetType  MetroComboBox �� Property �� Value  	TextBrush  GrayBrush10  TextBoxBorderBrush  ContentFontFamily  ContentFontSize  MetroComboBoxItem  ValidationErrorTemplate �� 
TargetType � 	Resources 	 Key'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value ��Name ��Name 
 
WhiteBrush J� IsHitTestVisible J� Opacity  
GrayBrush8  
GrayBrush7 % !ComboBoxMouseOverInnerBorderBrush  HighlightBrush � ColumnDefinitions �� RelativeSource �� AncestorType �� Path �� Mode ��Name  ChromelessButtonStyle �� 	Converter F�Name J� SnapsToDevicePixels �� Stretch  
GrayBrush1 �� Triggers P� 
SourceName P� Property P� Value �� 
TargetName  
GrayBrush5  AccentColorBrush  
BlackBrush g� Duration  R� KeyTime! R� Value  System.Windows.Visibility" d�Name  comboToggleStyle-  'System.Windows.Input.KeyboardNavigation#   	IsTabStop$ d� 	IsChecked% ��Name4   .BackupSystem.Styles.Wpf.Controls.TextboxHelper&   	Watermark' �� 
IsReadOnly( �� 
IsReadOnly) �Name* �� SelectionBoxItemTemplate+ �� SelectionBoxItem#, �� SelectionBoxItemStringFormat- �� ContentStringFormat  DisabledWhiteBrush. �Name/ � AllowsTransparency  DropShadowBrush0 J� Effect  ComboBoxPopupBrush1 ��Name2 ��Name3   DirectionalNavigation4 �� Value5 �� Binding  VirtualisedMetroComboBox6 �� BasedOn7 K� IsItemsHost8 %� IsVirtualizing9 %� VirtualizationMode: �� Triggers  AccentColorBrush3; ��Name  AccentSelectedColorBrush�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;Controls.clr-namespace:BackupSystem.Styles.Wpf.Controls  5      %k%  &	        &	      7   &	 �    7  &	 �    �� 5      6#   �� 5      "  ��6   .�5	   
   ��  � ��$ 26��5
      �� 5   
    � ��# �  5      �� 5   
    � ��# �  5      �� 5   
    � ��$
 Left=�5      �� 5   
    � ��$ Center=�5      �� 5   
    � ��$ 1q�5      �� 5   
    � ��$ 0q�5      �� 5   
    � ��$
 Auto=�5      �� 5   
    � ��$
 Auto=�5      �� 5   
    � ��# �  5      �� 5   
    � ��# �  5      �� 5   
    � ��# �  5       �� 5!   
    � ��# �  5"      �� 5$   
    �@J�SnapsToDevicePixels . 5%      �� 5&   
    �@=�ErrorTemplate# �  5'      �� 5(   
    � �� .  5)      �� 5*   
    � �� 5+      �� 5,      " ��6"   .R�5-      �  5.      ���� 5/      comboToggleStyle	 "  d�50   $   .�51   "   ��  � ��# �  52   )   �� 53   "    � ��# �  54   )   �� 55   "    � ��# �  56   )   �� 57   "    � ��$ 1q�58   )   �� 59   "    � ��$ 3q�5:   )   �� 5;   "    � �� 5<   &   �� 5=   *   " d�6:   .R�5>   .   �  5?   2     5@   6   CommonStates��. 5A   :     
Normal��6F     5B   :   	MouseOver��. 5C   >   �� .��5D   B   U� $ (UIElement.Opacity)�6`   $	 MouseOverBorder��5E   `   .\�5F   F     $
 0��6[   $ 1Q�5G   [   5H   C   5I   ?   5J   ;     5K   :   Pressed��. 5L   >   �� .��5M   B   U� $ (UIElement.Opacity)�6`   $	 PressedBorder��5N   `   .\�5O   F     $
 0��6[   $ 1Q�5P   [   5Q   C   5R   ?   5S   ;     5T   :   Disabled��6F   5U   7     5V   6   FocusStates��. 5W   :     Focused��. 5X   >   �� .��5Y   B   U� $ (UIElement.Opacity)�6`   $	 FocusRectangle��5Z   `   .\�5[   F     $
 0��6[   $ 1Q�5\   [   5]   C   5^   ?   5_   ;     5`   :   	Unfocused��6F   5a   7   .+�5d   2   �� $ 
Background��69   #��z��5e   9   #��z��5f   9   #��z��5g   9   �� 5h   2   $ DisabledVisualElement��6<   #��� 
 5i   <    .  $ 0Q�5k   <   �� 5l   2   $ MouseOverBorder��69   #���  5m   9   #��z��5n   9   $ 0Q�5o   9   �� 5p   2   $ PressedBorder��69   #���  5q   9   #��z��5r   9   $ 0Q�5s   9   �� 5t   2   $ FocusRectangle��6<   #���  5u   <   $ 0Q�5v   <   �� 5w   2   $ FocusVisualElement��6<    .  $��1q�5y   <   #���  5z   <   $��1��5{   <   $y�	Collapsed=�5|   <   � 5~   2   $��1q�67    5   6   �� 5�   :   $��* �6K   �� 5�   :   ��6K   ��  �� *FindAncestor+" �$ ActualHeight�$ OneWay=��� 5�   :   ��6K   ��  �� *FindAncestor+" �$ ActualHeight�$ OneWay=�.+�5�   6   �� $ PART_ClearText��6=   $��1��5�   =   $��16(�5�   =   #���  5�   =   #��z��5�   =   $��Marlett)�5�   =   $��r��5�   =   ��.  y�5�   =   ��  �� " ��$. ((Controls:TextboxHelper.ClearTextButton)�8   5�   =   �� 5�   6   $ BtnArrowBackground��6@   $��2��5�   @   
������ $��0��5�   @   F� 5�   6   $ BtnArrow��6;   $��2��5�   ;    .  # z 5�   ;   +���� ��v���P.��v���8�BІ�� ��v��$��Center=�5�   ;   $��4��5�   ;   $ Uniform=�5�   ;   $��8��5�   ;   #���  5�   ;   5�   3   5�   /    5�   .   P� 5�   2   $ BtnArrowBackground��6:    �@J�IsMouseOver . . �5�   6   �� $ BtnArrowBackground��6=   # �  5�   =    � ��5�   3   P� 5�   2   $ PART_ClearText��6:    �@J�IsMouseOver . . �5�   6   �� $ PART_ClearText��6=   # �  5�   =    � ���� 5�   6   $ PART_ClearText��6=   # �  5�   =    � ��5�   3   P� 5�   2   $ PART_ClearText��6:    � �� . . �5�   6   �� $ PART_ClearText��6=   # �  5�   =    � ���� 5�   6   $ PART_ClearText��6=   # � 
 5�   =    � ��5�   3   5�   +   5�   #   5�      5�       5�        5�      CommonStates��. 5�   "     
Normal��6.     5�   "   	MouseOver��6.     5�   "   Disabled��. 5�   &   �� .��5�   *   U� $ (UIElement.Opacity)�6H   $	 DisabledVisualElement��5�   H   .\�5�   .   �� $
 00:00:00��6C   $
 0.45Q�5�   C   5�   +   5�   '   5�   #   5�        5�      FocusStates��. 5�   "     Focused��. 5�   &   �� .��5�   *   U� $ (UIElement.Opacity)�6H   $	 FocusRectangle��5�   H   .\�5�   .     $
 0��6C   $ 1Q�5�   C   5�   +   5�   '   5�   #     5�   "   	Unfocused��6.     5�   "   FocusedDropDown��. 5�   &   �� .��5�   *   T� $ 00:00:00D�6H   $ (UIElement.Visibility)�5�   H   $	 PopupBorder��5�   H   ..�5�   .   i� $  00:00:00��6E   ! 5�   2    5�   6   Visible=�6J   5�   /   5�   +   5�   '   5�   #   5�      .+�5�      �  5�      �� 5�   "   $��* �63   �� 5�   "   ��63   ��  �� *FindAncestor+" �$ ActualHeight�$ OneWay=��� 5�   "   ��63   ��  �� *FindAncestor+" �$ ActualHeight�$ OneWay=�.+�5�      d� $" PART_DropDownToggle��6+   $��3��5�   +   #��z��5�   +   #��z��5�   +   #��z��5�   +   $��0q�5�   +   #���  5�   +   $��Stretch=�5�   +   # .  $ 5�   +   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5�   +   �� 5�      $ EditableTextBoxBorder��6%   $y�	Collapsed=�5�   %   
������ $��1,1,0,1q�5�   %   $��0,0,-2,0q�5�   %   #��z��5�   %   ._�5   "   �� $% PART_EditableTextBox��6*   $��Stretch=�5  *   # z 5  *   #��z��5  *   #��z��5  *   $��0q�5  *   $��0,0,0,-2q�5  *   #& z& 5  *   #��z��5	  *   |�. #( z' 5  *   #��z��5  *   #��z��5  *   ��5  *   Z� 5  *   5     � 5     $) ContentSite��6#   $��7 0 0 0q�5  #   .+�5  "   �� #��z* 63   #��z��5  3   #��z+ 5  3   #- z, 5  3   #��z��5  3    .  #��z��5  3   # z 5  3   #��z��5  3   5     5     �� 5     $ FocusRectangle��6$   #���  5  $   $ 0Q�5  $   �� 5     $ DisabledVisualElement��6$   #���  5   $    .  $ 0Q�5"  $   � 5$     $. 
PART_Popup��6    / . |�.  #��� .�5(      $��Bottom=�5)      ��5'      �� *IsDropDownOpen+ �� *TemplatedParent+.��5*     � ��6#   �� *ActualWidth+ �� *TemplatedParent+��5+  #   �� *MaxDropDownHeight+ �� *TemplatedParent+.+�5,  "   �� $ PopupBorder��6)   #0 �  5-  )   #��z��5.  )   $��Stretch=�5/  )   $
��Auto��50  )   #���  51  )   #��� 
 52  )   53  #   �� 54  "   $1 DropDownScrollViewer��6/   $��0q�55  /   $��2q�56  /   $��1q�57  /   .��58  &   �� $2 ItemsPresenter��65   $3 	Contained=�59  5   5:  #   5;     5<     5=      5>     �� 5?     $4 False��5@  &   5 5?  &   ��  �� *Self+$. ((Controls:TextboxHelper.ClearTextButton)�.a�5A     �� $ EditableTextBoxBorder��6%    � ��$ 2��5C  %   �� 5D     $ ContentSite��6%    � ��$ 2��5F  %   5G     P� 5H      �@��
IsEditable . . �5J     ��  � �� .  5K  %   �� 5L     $ EditableTextBoxBorder��6%    � y�$ Visible=�5N  %   �� 5O     $ ContentSite��6%    � y�$ Hidden=�5Q  %   �� 5R     $ PART_DropDownToggle��6%    � |� .  5T  %   5Y     5[     5]     5^     �� 5`     "  ��5a     86   .�5c  
   ��  � �� 5d     �� 5e     .R�5f     $� 7 . $3 	Contained=�5g  -   8 . $9 	Recycling=�5i  -   5j     5l     �� 5m  
    � �� . 5n     : 5o  
   P� 5p      �@��
IsGrouping . . �5q     ��  � �� .  5r     5s     5u     �� 5w     "  ��6   .�5y  
   ��  � ��# �  5z     �� 5{  
    � ��$ 2q�5|     �� 5}  
    � ��$
 Left=�5~     �� 5  
    � ��$	 Top=�5�     �� 5�  
    �@��ClearTypeHint$ Enabled=�5�     �� 5�  
    � ��# � 
 5�     �� 5�  
    � ��$ 1q�5�     �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     � #��z��6   $��0,0.5q�5�      5�       5�     CommonStates��. 5�  "     
Normal��6.     5�  "   	MouseOver��. 5�  &   �� .��5�  *   U� $ (UIElement.Opacity)�6H   $	 MouseOverRectangle��5�  H   .\�5�  .     $
 0:0:0.1��6C   $	 .65Q�5�  C   5�  +   5�  '   5�  #     5�  "   Disabled��. 5�  &   �� .��5�  *   U� $ Opacity�6H   $	 contentPresenter��5�  H   .\�5�  .   �� $
 0��6C   $	 .55Q�5�  C   5�  +   5�  '   5�  #   5�       5�     SelectionStates��. 5�  "     
Unselected��6.     5�  "   Selected��. 5�  &   �� .��5�  *   U� $ (UIElement.Opacity)�6H   $	 SelectedRectangle��5�  H   .\�5�  .     $
 0:0:0.1��6C   $ 1Q�5�  C   5�  +   5�  '   5�  #   5�       5�     FocusStates��. 5�  "     Focused��. 5�  &   �� 5�  #     5�  "   	Unfocused��6.   5�     .+�5�     �� $ SelectedRectangle��6$    .  $ 0Q�5�  $   #���  5�  $   �� 5�     $ MouseOverRectangle��6$    .  $ 0Q�5�  $   #���  5�  $   �� 5�     #��z��6)   .��5�     �� $; contentPresenter��6/   #��z��5�  /   #��z��5�  /   #��z��5�  /   5�     �� 5�     $ FocusVisualElement��6$   #���  5�  $   $��1��5�  $   $y�	Collapsed=�5�  $   5�      5�     P� 5�      �@��
IsSelected . . �5�     �� # �  5�  %    � ��5�     5�     5�     5�     5�     