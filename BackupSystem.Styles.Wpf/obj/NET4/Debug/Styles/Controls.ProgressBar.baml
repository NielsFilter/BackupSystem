   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   MetroProgressBar �� Property  HighlightBrush �� Value  
GrayBrush5  TextBoxBorderBrush �� 
TargetType �Name'    !System.Windows.VisualStateManager    VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState   
Storyboard g� RepeatBehavior	 g� Duration
 �� TargetProperty �� 
TargetName R� KeyTime R� Value  System.Windows.Visibility O� KeyTime O� Value ��Name ��Name J� Opacity J� RenderTransformOrigin  ProgressBrush �� EndPoint � MappingMode � SpreadMethod �� 
StartPoint �� 	Transform T� X �� AngleX  ProgressIndeterminateColor1 � Color � Offset  ProgressIndeterminateColor2  ProgressIndeterminateColor3  ProgressIndeterminateColor4 �� Triggers P� Property P� Value  �� 
TargetName! �� Angle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %Z  &	        �� 5      "  �6   .�5   
   ��  � ��# �  5      �� 5   
    � ��# �  5	      �� 5
   
    �@�Maximum$	 100Q�5      �� 5   
    � ��$ 10��5      �� 5   
    � �� .  5      �� 5   
    � ��# �  5      �� 5   
    � �� 5      �� 5      " �6"   .R�5      � $
 Root��6    5        5      CommonStates��. 5   "     Determinate��6.     5   "   Indeterminate��. 5   &   �� $ Forever��61   .��5   *   T� $	 00:00:00D�6H   $
 (UIElement.Visibility)�5   H   $ IndeterminateRoot��5   H   ..�5   .   i� $ 00:00:00��6E    5   2    5    6   Visible=�6J   5"   /   5#   +   T� 5$   *   $	 00:00:00D�6H   $
 (UIElement.Visibility)�5%   H   $ DeterminateRoot��5&   H   ..�5'   .   i� $ 00:00:00��6E    5(   2    5)   6   	Collapsed=�6L   5+   /   5,   +   U� 5-   *   $
 X�6H   $ 
xTransform��5.   H   .\�5/   .   �� $ 0��6C   $ 0Q�50   C   �� 51   .   $ 	00:00:.35��6C   $ 20Q�52   C   53   +   54   '   55   #   56      .+�58      �� $ 
PART_Track��6!   #��z��59   !   #��z��5:   !   #��z��5;   !   � 5<      $ ProgressBarRootGrid��6   .+�5=      � $ IndeterminateRoot��6#   $y�	Collapsed=�5>   #   .+�5?   "   �� $ IndeterminateSolidFill��6,   #��z��5@   ,   $ 1Q�5A   ,   $ 0.5,0.5&�5B   ,   $��0��5C   ,   #���  5D   ,   �� 5E   "   $ IndeterminateGradientFill��6,   #��z��5F   ,   $	 0.7Q�5G   ,   $��1��5H   ,   ��5I   &   �� 5J   *   $	 0,1&�6>   $ Absolute=�5K   >   $ Repeat=�5L   >   $
 20,1&�5M   >    5N   .   V� 5O   2   .~�5P   6   T� $ 0Q�6I   
xTransform��5Q   I   �� 5R   6   $	 -30Q�6D   5S   3   .��5U   .   � # �  6;   $ 0Q�5V   ;   � 5W   .   # �  6;   $ 0.651Q�5X   ;   � 5Y   .   # �  6;   $ 0.093Q�5Z   ;   � 5[   .   # �  6;   $ 0.548Q�5\   ;   5]   +   5_   #   5`      � 5a      $ DeterminateRoot��6#   $��1q�5b   #   .+�5c   "   �� $ PART_Indicator��6)   #���  5d   )   $
��Left=�5e   )   $��-1q�5f   )   ._�5g   &   �� $ GradientFill��60   $	 0.7Q�5h   0   $y�	Collapsed=�5i   0   ��5j   *   �� 5k   .   $	 0,1&�6B   $ Absolute=�5l   B   $ Repeat=�5m   B   $
 20,1&�5n   B    5o   2   V� 5p   6   .~�5q   :   T� $ 0Q�6M   �� 5r   :   $	 -30Q�6H   5s   7   .��5u   2   � # �  6?   $ 0Q�5v   ?   � 5w   2   # �  6?   $ 0.651Q�5x   ?   � 5y   2   # �  6?   $ 0.093Q�5z   ?   � 5{   2   # �  6?   $ 0.548Q�5|   ?   5}   /   5   '   5�   #   5�      5�      5�       5�      P� 5�       �@�Orientation$ Vertical=�5�   "   . �5�      �� $
  Root��5�   %    �@�LayoutTransform 5�   "   �� 5�   &   $	! -90Q�66   5�      5�      P� 5�       �@�IsIndeterminate . . �5�      �� $  IndeterminateRoot��5�   %    � y�$ Visible=�5�   %   �� 5�      $  DeterminateRoot��5�   %    � y�$ 	Collapsed=�5�   %   5�      5�      5�      �� 5�   
    � ��$ 1q�5�      5�      5�      