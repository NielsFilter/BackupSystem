   M S B A M L   `   `   `  ����I  EMahApps.Metro, Version=0.14.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MahApps.Metro.ControlsMahApps.Metro.Controls  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   MetroTabControl �� Property �� Value �� 
TargetType � ColumnDefinitions ��Name � RowDefinitions ��Name ��Name	 K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation
    TabIndex K� ZIndex ��Name    DirectionalNavigation    TabNavigation ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  MetroTabItem  AccentColorBrush  
BlackBrush+   %MahApps.Metro.Controls.ControlsHelper  TabItemFontSize �� Orientation � 	Resources  Key   HeaderFontSize   HeaderFontStretch   HeaderFontWeight ��Name �� RelativeSource �� Mode �� AncestorType �� Path   BooleanToVisibilityConverter �� 	Converter  GrayNormalBrush  P� 
SourceName  GrayHoverBrush! ]� 
Conditions" �� 
SourceName# �� Property$ �� Value 	 HighlightBrush�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1Controls$clr-namespace:MahApps.Metro.Controls  5      %T  &	        &	 �
    7  �� 5      "  ��6   .�5   
   ��  � �� 5      Z� �� 5	   
    � �� 5
      Z� �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �  5      �� 5      $ ColumnDefinition0��6/   �� 5      $ ColumnDefinition1��6/   $��0 �5   /    5      �� 5      $ RowDefinition0��6,   $
��Auto �5   ,   �� 5      $ RowDefinition1��6,   $��* �5   ,   .+�5      �� $ HeaderPanel��6#   $��0��5   #   	 . $��0��5   #   $
 1��5   #   $ 1��5   #   �� 5       $ ContentPanel��6!   #��z��5!   !   #��z��5"   !   #��z��5#   !   $��0��5$   !   $ 	Contained=�5%   !   $��1��5&   !   $
 2��5'   !   $ Local=�5(   !   ._�5)      �� $ PART_SelectedContentHost��6/   $��SelectedContent��5*   /   #��z��5+   /   # z 5,   /   5-      5.       5/      P� 50       �@��TabStripPlacement$ Bottom=�51   "   . �52      �� $ HeaderPanel��53   %    � ��$ 1��54   %   �� 55      $ ContentPanel��56   %    � ��$ 0��57   %   �� 58      $ RowDefinition0��59   %    � ��$ * �5:   %   �� 5;      $ RowDefinition1��5<   %    � ��$
 Auto �5=   %   �� 5>      $ HeaderPanel��5?   %    � ��$ 2,0,2,2q�5@   %   5A      P� 5B       �@��TabStripPlacement$
 Left=�5C   "   . �5D      �� $ HeaderPanel��5E   %    � ��$ 0��5F   %   �� 5G      $ ContentPanel��5H   %    � ��$ 0��5I   %   �� 5J      $ HeaderPanel��5K   %    � ��$ 0��5L   %   �� 5M      $ ContentPanel��5N   %    � ��$ 1��5O   %   �� 5P      $ ColumnDefinition0��5Q   %    � ��$
 Auto �5R   %   �� 5S      $ ColumnDefinition1��5T   %    � ��$ * �5U   %   �� 5V      $ RowDefinition0��5W   %    � ��$ * �5X   %   �� 5Y      $ RowDefinition1��5Z   %    � ��$ 0 �5[   %   �� 5\      $ HeaderPanel��5]   %    � ��$ 2,2,0,2q�5^   %   5_      P� 5`       �@��TabStripPlacement$ Right=�5a   "   . �5b      �� $ HeaderPanel��5c   %    � ��$ 0��5d   %   �� 5e      $ ContentPanel��5f   %    � ��$ 0��5g   %   �� 5h      $ HeaderPanel��5i   %    � ��$ 1��5j   %   �� 5k      $ ContentPanel��5l   %    � ��$ 0��5m   %   �� 5n      $ ColumnDefinition0��5o   %    � ��$ * �5p   %   �� 5q      $ ColumnDefinition1��5r   %    � ��$
 Auto �5s   %   �� 5t      $ RowDefinition0��5u   %    � ��$ * �5v   %   �� 5w      $ RowDefinition1��5x   %    � ��$ 0 �5y   %   �� 5z      $ HeaderPanel��5{   %    � ��$ 0,2,2,2q�5|   %   5}      5      5�      5�      �� 5�      "  ��6   .�5�   
   ��  �@�FocusVisualStyle 5�      Z� �� 5�   
    � �� .  5�      �� 5�   
    � ��$ 6,2,6,2q�5�      �� 5�   
    � ��$ Stretch=�5�      �� 5�   
    � ��$ Stretch=�5�      �� 5�   
    � ��$ 5��5�      �� 5�   
    � ��$ 5��5�      �� 5�   
    � ��$ 0q�5�      �� 5�   
    � ��# �  5�      �� 5�   
    � ��
 ���� 5�      �� 5�   
    � ��# �  5�      �� 5�   
    �@J�SnapsToDevicePixels . 5�      �� 5�   
    �@ HeaderFontSize# �  5�      �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ Border��6   $��Stretch=�6-   #��z��5�      #��z��5�      #��z��5�      # z 5�      ._�5�      �� $ Vertical=�6%   $��Stretch=�6<    5�      ���� 5�   "    BooleanToVisibilityConverter 6?   5�      .+�5�      �� $ ContentSite��6/   #��z��5�   /   #��z��5�   /   #��z��5�   /   #��z 5�   /   #��z 5�   /   #��z 5�   /   #��z��5�   /   $��Header��5�   /   ��. 5�   /   �� 5�      $ 	Underline��6(   $��
0, 1, 0, 0q�5�   (   $��2��5�   (   $��Stretch=�5�   (   y�5�   (   ��  �� $ FindAncestor=�" ��$. ((Controls:TabControlHelper.IsUnderlined)�8   5�      5�       5�      P� 5�       �@��
IsSelected . . �5�      �� $ ContentSite��5�   %   # �  5�   %    � ���� 5�      $ 	Underline��5�   %   # �  5�   %    � ��5�      P� 5�       �@��
IsSelected .  . �5�      �� $ ContentSite��5�   %   # �  5�   %    � ���� 5�      $ 	Underline��5�   %   # �  5�   %    � ��5�      P� 5�      $  ContentSite��6"    �@J�IsMouseOver . . �5�      �� $ ContentSite��5�   %   # �  5�   %    � ���� 5�      $ 	Underline��5�   %   # �  5�   %    � ��5�      ]� 5�      ! 5�      �� 5�   "   $" ContentSite��6C   # �@J�IsMouseOver$ . 6\   �� 5�   "   # �@��
IsSelected$ . 6B   ./�5�      �� $ ContentSite��5�   %   # � 	 5�   %    � ���� 5�      $ 	Underline��5�   %   # � 	 5�   %    � ��5�      5�      5�      5�      5�      