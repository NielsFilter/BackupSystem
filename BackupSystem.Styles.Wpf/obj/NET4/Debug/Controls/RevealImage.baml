   M S B A M L   `   `   `  ����  BackupSystem.Styles.Wpf2    ,BackupSystem.Styles.Wpf.Controls.RevealImage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  revealImage��5       � 	Resources 5	         OnMouseEnter1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  OnMouseLeave1��%�  &	        &	 n    �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $ border��6\   .\�5        $ 0��6'   $ 0Q�63    5        5      $ EaseOut=�6%   5        5      $ 0:0:0.3��6'   $ 1Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ 	textBlock��6\   .\�5        $ 0:0:0.0��6'   $ 1Q�69   5      5      �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $ 	textBlock��6\   .\�5        $ 0:0:0.2��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ border��6\   .\�5        $ 0:0:0.2��6'   $ 0Q�69   5      5      5        � Triggers 5#      :� 5$   
   	 :� RoutedEvent$	 Mouse.MouseEnter��6   
 :� 
SourceName$

 grid��66   .[�5%      �� #��[  6   5&      :� 5'   
   $	 Mouse.MouseLeave��6   $

 grid��66   .[�5(      �� -   5         ��Name$# OnMouseLeave1_BeginStoryboard��5(      #��[ 6E   5)      .��5,      � -   5         �Name$
 grid��5,      .+�5-   
   �� $
��Fill=�6G   $
��Left=�6V   $	��Top=�6q   $��0q�6�   ��6   ��  �� ElementName$ revealImage�� �� Path$ Image�6�   �� 5.   
   -   5         ��Name$ border��5.      
�������$��2q�65    J� Opacity$ 0Q�6I   ._�5/      �� $��0q�6   
���   �$��0��62   ��50      
� 51       
� Center$ 	0.25,0.25&�6*    
� GradientOrigin$ 	0.25,0.25&�6=    �� Opacity$ 0.615Q�6X   .��52      �  � Color$ Black��6'    � Offset$ 1Q�65   � 53      $ 	#FF8D8D8D��6'   54      56      57      �� 58   
   -   5         ��Name$ 	textBlock��58      $
��Wrap=�59      $��Bottom=�5:      $��5q�63   
�������$��Segoe WP SemiLight)�5;   +   $ 0Q�5<      5=      5>      