   M S B A M L   `   `   `  ����G  CICEBERG-MALL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ICEBERG_MALLICEBERG_MALL  5          ICEBERG_MALL.StartPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ICEBERG_MALL     5        N� Title$  	StartPage��5	       N� WindowTitle$&  Добро пожаловать!��6    N� 
Background 5
      �� 5   
    �� ImageSource$ /images/startpage.jpg��6   6;   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ buttonAdmin��5      $2��,Вход для администратора��6&   $��Right=�6H   $��1��6e   $��35��6r   $��0,0,10,0q�6~   $	��165��6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  �� CornerRadius$ 25��6   #��z��60   ��5      �� 5      BorderColor��	 �� Color$	 	#FF69B6EB��6C   ._�5      �� #��z��6)   #��z��5      #��z��5      #��z��5       '  !System.Windows.VisualStateManager
   VisualStateGroups
 5!      %  System.Windows.VisualStateGroup  5"         Name$ CommonStates��6/      States. 5#   "      System.Windows.VisualState     Name$ 	MouseOver��6.      
Storyboard. 5$   &   �� .��5%   *   ��  �� 
TargetName$ BorderColor��69    �� TargetProperty$ Color�5&   %   	 �� To$ 
DodgerBlueX�6G   5'   '   5(   #     5)   "   $ Normal��6.   . 5*   &   �� .��5+   *   �� $ BorderColor��69   $ Color�5,   %   $ 	#FF69B6EBX�6G   5-   '   5.   #   5/      51      52      54      �� 55   
   -   5        $ 
buttonUser��55      $+��%Продолжить просмотр��6%   $
��Left=�6C   $��1��6^   $��1��6n   $��35��6{   $��10,0,0,0q�6�   $	��165��6�   ��56      �� 57      " ��6"   .R�58      �� $ 25��6   #��z��60   ��59      �� 5:      BorderColor��$	 	#FF69B6EB��6C   ._�5<      �� #��z��6)   #��z��5=      #��z��5>      #��z��5?      
 5@        5A      $ CommonStates��6/   . 5B   "     $ 	MouseOver��6.   . 5C   &   �� .��5D   *   �� $ BorderColor��69   $ Color�5E   %   $ 
DodgerBlueX�6G   5F   '   5G   #     5H   "   $ Normal��6.   . 5I   &   �� .��5J   *   �� $ BorderColor��69   $ Color�5K   %   $ 	#FF69B6EBX�6G   5L   '   5M   #   5N      5P      5Q      5S      �� 5T   
   -   5         ��Name$ textBlockNameMall��5T       �� Padding$ 0,20,0,0q�61   $
��Bold"�6D   $	��Top=�6V   $�� 2��6n    �� TextAlignment$ Center=�6�   $��0,65,0,0q�6�   $��49(�6�   $��ICEBERG MALL��6�   5W      5X      